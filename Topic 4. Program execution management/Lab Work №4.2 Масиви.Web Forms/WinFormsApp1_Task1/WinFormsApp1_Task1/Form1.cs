namespace WinFormsApp1_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button1.Click += new EventHandler(Button1_Click); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[10];


            numbers[0] = Convert.ToInt32(TextBox1.Text);
            numbers[1] = Convert.ToInt32(TextBox2.Text);
            numbers[2] = Convert.ToInt32(TextBox3.Text);
            numbers[3] = Convert.ToInt32(TextBox4.Text);
            numbers[4] = Convert.ToInt32(TextBox5.Text);
            numbers[5] = Convert.ToInt32(TextBox6.Text);
            numbers[6] = Convert.ToInt32(TextBox7.Text);
            numbers[7] = Convert.ToInt32(TextBox8.Text);
            numbers[8] = Convert.ToInt32(TextBox9.Text);
            numbers[9] = Convert.ToInt32(TextBox10.Text);

            int maxIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Label1.Text = "Number of the maximum element: " + (maxIndex + 1);
        }
    }
}
