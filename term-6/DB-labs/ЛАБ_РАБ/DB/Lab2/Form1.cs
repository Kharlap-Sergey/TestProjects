using Models;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            employes_listBox.Items.Clear();

            Logic.GetAllEmployes()
                .ForEach(employes => employes_listBox.Items.Add(employes.Name + " " + employes.Surname));

        }

        private void addNewEmpl_btn_Click(object sender, EventArgs e)
        {
            var employe = new Employe();
            employe.Name = LastName_txtBox.Text;
            employe.Surname = firstName_txtBox.Text;
            employe.FatherName = fatherName_txtBox.Text;

            var newId = Logic.CreateNewEmploye(employe);
            newId_txtBox.Text = newId.ToString();
        }

        private void calculateCount_btn_Click(object sender, EventArgs e)
        {
            count_textBox.Text = Logic.GetCountOfAllEmployes().ToString();
        }
    }
}