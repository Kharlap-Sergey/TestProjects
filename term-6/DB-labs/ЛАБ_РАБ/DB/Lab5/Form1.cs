using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Models;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public static string ConnectionString { get; set; } =
            Constants.ConnectionString;

        protected List<string> columnNames = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listBox2.DataSource = new List<string> {"","Price > 10", "Count > '10'"};
            listBox3.DataSource = new List<string> {"", "Type = 'Supplies'", "Type = 'Sales'"};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var historyAdapter = new SqlDataAdapter(
                "SELECT * FROM ACTUAL_FULL_HISTORY_WITH_PRODUCTS_VIEW",
                connection
            );
            var fullHistoryS = new DataSet();
            historyAdapter.Fill(fullHistoryS, "Histories");
            var fullHistory = fullHistoryS.Tables["Histories"];
            columnNames.Clear();
            foreach (DataColumn column in fullHistory.Columns)
            {
               columnNames.Add(column.ColumnName);
            }

            var fullHistoryView = new DataView(fullHistory);

            table_dataGridView.DataSource = fullHistory;
            view_dataGridView.DataSource = fullHistoryView;

            listBox1.DataSource = columnNames;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = view_dataGridView.DataSource as DataView;
            view.Sort = listBox1.SelectedItem.ToString();
        }

        private string con1 = "";
        private string con2 = "";
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con1 = listBox2.SelectedItem.ToString();
            ChangeCondition();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con2 = listBox3.SelectedItem.ToString();
            ChangeCondition();
        }

        private void ChangeCondition()
        {
            var view = view_dataGridView.DataSource as DataView;
            if (view == null)
                return;

            var condition = con1 + (con1 != "" && con2 != "" ? " and " : "") + con2;
            view.RowFilter = condition;
        }
    }
}
