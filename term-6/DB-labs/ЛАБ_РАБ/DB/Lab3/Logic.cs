using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Lab3
{
    partial class Form1
    {
        public static string ConnectionString { get; set; } =
            "Data Source=WSA-220-71;Initial Catalog=db2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DataTable GetProducts()
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = @"SELECT TOP (1000) [ID]
      ,[NAME]
      ,[PRICE]
      ,[PRODUCT_CATEGORY_ID]
      ,[IS_DELETED]
  FROM [db2].[dbo].[PRODUCTS]";
            var adapter = new SqlDataAdapter(command, connection);
            DataSet products = new DataSet();
            adapter.Fill(products, "Products");

            return products.Tables[0];
        }

        public DataRow AddRowToProducts(string productName, ushort price)
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = @"SELECT TOP (1000) [ID]
      ,[NAME]
      ,[PRICE]
      ,[PRODUCT_CATEGORY_ID]
      ,[IS_DELETED]
  FROM [db2].[dbo].[PRODUCTS]";
            var adapter = new SqlDataAdapter(command, connection);
            DataSet productsS = new DataSet();
            adapter.Fill(productsS, "PRODUCTS");

            var products = productsS.Tables["PRODUCTS"];

            var row = products.NewRow();
            row["Name"] = productName;
            row["PRICE"] = price;
            row["PRODUCT_CATEGORY_ID"] = 1;

            products.Rows.Add(row);

            new SqlCommandBuilder(adapter);
            adapter.Update(products);

            return row;
        }

        public DataTable CreateTestTable()
        {
            DataSet products = new DataSet("Test");
            DataTable empTable = products.Tables.Add("Employees1");
            DataColumn empID = empTable.Columns.Add("EmployeeID", typeof(Int32));
            empID.AutoIncrement = true;
            empID.AutoIncrementSeed = 200;
            empID.AutoIncrementStep = 3;
            empTable.Columns.Add("LName", typeof(string));
            empTable.Columns.Add("FName", typeof(string));
            empTable.Columns.Add("MName", typeof(string));
            empTable.PrimaryKey = new DataColumn[] { empTable.Columns["EmployeeID"] };

            var newRow = CreateTestRow(empTable , "sadfasdf", "assdfasdf", "adfasdf");
            var newRow1 = CreateTestRow(empTable , "1sadfasdf", "1assdfasdf", "adfasdf");
            var newRow2 = CreateTestRow(empTable , "2sadfasdf", "2assdfasdf", "adfasdf");

            empTable.Rows.Add(newRow);
            empTable.Rows.Add(newRow1);
            empTable.Rows.Add(newRow2);

            return products.Tables[0];
        }

        private DataRow CreateTestRow(DataTable newTable,string a, string b, string c)
        {
            var newRow = newTable.NewRow();

            newRow["LName"] = a;
            newRow["FName"] = b;
            newRow["MName"] = c;

            return newRow;
        }
    }
}