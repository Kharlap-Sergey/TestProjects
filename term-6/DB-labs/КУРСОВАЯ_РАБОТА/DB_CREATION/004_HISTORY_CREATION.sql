CREATE TYPE PRODUCT_LIST_TYPE_2 AS TABLE
(
	PRODUCT_ID INT NOT NULL,
	AMOUNT INT NOT NULL,
	PRICE MONEY NOT NULL
);
GO;

CREATE OR ALTER PROCEDURE CHANGE_PRODUCT_WAREHOUSE_LINK
	@PRODUCT_ID INT,
	@WAREHOUSE_ID INT,
	@COUNT INT
AS
BEGIN

	IF EXISTS(SELECT * FROM WAREHOUSE_PRODUCT WHERE PRODUCT_ID = @PRODUCT_ID AND WAREHOUSE_ID = @WAREHOUSE_ID)
		UPDATE WAREHOUSE_PRODUCT
		SET COUNT = COUNT + @COUNT
		WHERE PRODUCT_ID = @PRODUCT_ID AND WAREHOUSE_ID = @WAREHOUSE_ID
	ELSE
		INSERT INTO WAREHOUSE_PRODUCT (WAREHOUSE_ID, PRODUCT_ID, COUNT)
		VALUES (@WAREHOUSE_ID, @PRODUCT_ID, @COUNT)

END;

GO

CREATE OR ALTER PROCEDURE CREATE_HISTORY
	@HISTORY_TYPE_ID INT ,
	@DATE DATETIME,
	@HISTORY_ID INT OUTPUT
AS 
BEGIN 
	INSERT INTO HISTORIES (DATE, HISTORY_TYPE_ID)
	VALUES (@DATE, @HISTORY_TYPE_ID)

	SET @HISTORY_ID = SCOPE_IDENTITY();
	
END

GO

GO
CREATE OR ALTER PROCEDURE NEW_HISTORY_EVENT
	@PRODUCT_ITEMS PRODUCT_LIST_TYPE_2 READONLY,	
	@HISTORY_TYPE_ID INT,
	@WAREHOUSE_ID INT,
	@DATE DATETIME,
	@UPDATER INT
AS
BEGIN

	DECLARE @HISTORY_ID INT;
	EXECUTE CREATE_HISTORY @HISTORY_TYPE_ID, @DATE, @HISTORY_ID OUTPUT;

	INSERT INTO HISTORY_PRODUCT (PRODUCT_ID, HISTORY_ID, COUNT, WAREHOUSE_ID, PRICE)
	SELECT P.PRODUCT_ID, @HISTORY_ID, @UPDATER * P.AMOUNT, @WAREHOUSE_ID, PRICE*-1*@UPDATER
	FROM @PRODUCT_ITEMS P

END;

GO

CREATE OR ALTER PROCEDURE NEW_SALE
	@PRODUCT_ITEMS PRODUCT_LIST_TYPE_2 READONLY,	
	@WAREHOUSE_ID INT,
	@DATE DATETIME
AS
BEGIN
	EXEC NEW_HISTORY_EVENT @PRODUCT_ITEMS, 2, @WAREHOUSE_ID, @DATE, -1
END;
	
GO

CREATE OR ALTER PROCEDURE NEW_SUPPLY
	@PRODUCT_ITEMS PRODUCT_LIST_TYPE_2 READONLY,	
	@WAREHOUSE_ID INT,
	@DATE DATETIME
AS
BEGIN
	EXEC NEW_HISTORY_EVENT @PRODUCT_ITEMS, 1, @WAREHOUSE_ID, @DATE, 1
END;
	
GO


GO

CREATE OR ALTER TRIGGER AFTER_INSERT_TRIGGER ON HISTORY_PRODUCT
AFTER INSERT
AS
BEGIN
	DECLARE 
		@TEMP AS TABLE(
			ROW_N INT,
			PRODUCT_ID INT,

			WAREHOUSE_ID INT,
			COUNT INT
		)
	DECLARE
		@PRODUCT_ID INT,
		@WAREHOUSE_ID INT,
		@COUNT INT

	INSERT INTO @TEMP
	SELECT ROW_NUMBER() OVER(ORDER BY COUNT ASC), PRODUCT_ID, WAREHOUSE_ID, COUNT FROM INSERTED

	WHILE Exists
	(
		select 1 
		from @TEMP
	)
	begin
		declare @TEMP_ID INT;
	
		SELECT TOP 1 
			@TEMP_ID = ROW_N, 
			@PRODUCT_ID = PRODUCT_ID,
			@WAREHOUSE_ID = WAREHOUSE_ID,
			@COUNT = COUNT
		from @TEMP 

		EXECUTE CHANGE_PRODUCT_WAREHOUSE_LINK @PRODUCT_ID, @WAREHOUSE_ID, @COUNT

		delete 
		from @TEMP
		where ROW_N = @TEMP_ID
	end
END;

GO

