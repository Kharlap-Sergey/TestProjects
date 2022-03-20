using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a_1 = 0f;
            float a_2 = 0f;
            int n;
            float h;
            float R = 0f;
            float a = 0f;
            h = float.Parse(textBox4.Text);
            a_1 = float.Parse(textBox2.Text);
            a_2 = float.Parse(textBox3.Text);
            n = int.Parse(textBox1.Text);
            richTextBox1.Text = "";
            
            
            while(a_1<a_2)
            {
                R = 1/(a_1 + (1 - a_1)/n);
                richTextBox1.Text += "  a = " + a_1 + "  R = " + R + "\n";
                chart1.Series[0].Points.AddXY(R, a_1);
                a_1 += h;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            float c_1 = 0f;
            float c_2 = 0f;
            float a = 0f;
            int n;
            float h;
            float Rc = 0f;
            float c = 0f;
            float Ct = float.Parse(textBox9.Text);
            a = float.Parse(textBox10.Text);

            h = float.Parse(textBox5.Text);
            c_1 = float.Parse(textBox7.Text);
            c_2 = float.Parse(textBox6.Text);
            n = int.Parse(textBox8.Text);
            richTextBox2.Text = "";
            while (c_1 <= c_2)
            {
                c = Ct*c_1;
                Rc = 1 / (a + (1 - a) / n + c);
                richTextBox2.Text += "  c = " + c_1 + "  Rc = " + Rc + "\n";
                chart2.Series[0].Points.AddXY(Rc, c_1);
                c_1 += h;
            }


        }
    }
}
