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
    }
}