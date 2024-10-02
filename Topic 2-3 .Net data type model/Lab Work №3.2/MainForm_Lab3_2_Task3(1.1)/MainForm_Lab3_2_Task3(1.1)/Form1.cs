namespace MainForm_Lab3_2_Task3_1._1_
{
    public partial class Form1 : Form
    {
        private const double radius = 1740; 

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  
            this.MaximizeBox = false; 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            txtSurfaceArea.Text = surfaceArea.ToString("F2"); 
            txtVolume.Text = volume.ToString("F2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
