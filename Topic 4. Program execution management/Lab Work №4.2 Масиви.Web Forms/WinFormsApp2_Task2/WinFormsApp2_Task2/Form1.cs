namespace WinFormsApp2_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label2.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[,] numbers = new int[3, 5];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    numbers[i, j] = rand.Next(1, 101);
                }
            }

            string result = "";

            for (int i = 0; i < 3; i++)
            {
                int max = numbers[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
                result += "Maximum element in row " + (i + 1) + ": " + max + "\n";
            }

            Label2.Text = result;
            Label2.Visible = true;
        }

    }
}
