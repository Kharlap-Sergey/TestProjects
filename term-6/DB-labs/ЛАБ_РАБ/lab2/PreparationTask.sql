create table employes (
	id int identity(1,1) not null,
	name nvarchar(100),
	surname nvarchar(100),
	fatherName nvarchar(100)
)

insert into employes
values ('a', 'b', 'c')

CREATE PROCEDURE InsEmployee
	-- Add the parameters for the stored procedure here
	@LName varchar(20),
	@FName varchar(20),
            @MName varchar(20),
	@EmployeeID int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO employes
	(surname, name, fatherName)
	VALUES (@FName, @LName, @MName);

SET @EmployeeID = @@IDENTITY
END
