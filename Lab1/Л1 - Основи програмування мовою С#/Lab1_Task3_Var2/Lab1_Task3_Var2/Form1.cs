namespace Lab1_Task3_Var2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridViewOutput.Columns.Add("Name", "Name");
            dataGridViewOutput.Columns.Add("Age", "Age");
            dataGridViewOutput.Columns.Add("Profession", "Profession");
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string age = textBoxAge.Text;
            string profession = textBoxProfession.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(profession))
            {
                MessageBox.Show("fill in all the fields.", "Error");
                return;
            }

            if (!int.TryParse(age, out int parsedAge) || parsedAge < 0)
            {
                MessageBox.Show("enter a valid age.", "Error");
                return;
            }

            dataGridViewOutput.Rows.Add(name, parsedAge, profession);
        }
    }
}
