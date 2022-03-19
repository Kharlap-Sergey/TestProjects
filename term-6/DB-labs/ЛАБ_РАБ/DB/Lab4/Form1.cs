using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public static string ConnectionString { get; set; } =
            @"Data Source=SIARHEI-KHARLAP\SQLEXPRESS;Initial Catalog=DB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private DataSet ds;
        private SqlDataAdapter productsAdapter;
        private SqlDataAdapter productCategoriesAdapter;
        private SqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);

            productsAdapter = new SqlDataAdapter(
                "Select * from Products",
                conn
            );

            productCategoriesAdapter = new SqlDataAdapter(
                "select * from PRODUCT_CATEGORIES",
                conn
            );

            ds = new DataSet();
            productsAdapter.Fill(ds, "Products");
            productCategoriesAdapter.Fill(ds, "ProductCategories");

            productCategories_dataGridView.DataSource = ds.Tables["ProductCategories"];
            products_dataGridView.DataSource = ds.Tables["Products"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(productsAdapter);
            var products = ds.Tables["Products"];
            var count = productsAdapter.Update(products);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var products = ds.Tables["Products"];
            products.RejectChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var products = ds.Tables["ProductCategories"];
            products.RejectChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(productCategoriesAdapter);
            var products = ds.Tables["ProductCategories"];
            var count = productCategoriesAdapter.Update(products);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var products = ds.Tables["Products"];
            var prodCat = ds.Tables["ProductCategories"];
            DataRelation relat = new DataRelation("Rel1",
                prodCat.Columns["id"],
                products.Columns["Product_category_id"]);
            ds.Relations.Add(relat);

            foreach (DataRow row in prodCat.Rows)
            {
                listBox1.Items.Add(row["name"]);
                DataRow[] childRows = row.GetChildRows(relat); // Получение связанных данных
                foreach (DataRow childRow in childRows) listBox1.Items.Add("    " + childRow["name"]);
            }

        }
    }
}