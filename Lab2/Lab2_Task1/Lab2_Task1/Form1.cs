using System;
using System.Windows.Forms;

namespace Lab2_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += ButtonCalculate_Click;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            LabelError.Text = string.Empty;
            double R1, R2, R3, R4;

            if (!double.TryParse(textBox1.Text, out R1) || R1 <= 0 ||
                !double.TryParse(textBox2.Text, out R2) || R2 <= 0 ||
                !double.TryParse(textBox3.Text, out R3) || R3 <= 0 ||
                !double.TryParse(textBox4.Text, out R4) || R4 <= 0)
            {
                LabelError.Text = "Enter correct positive values for all resistors.";
                return;
            }

            double Rtotal;
            if (RadioButtonSeries.Checked)
            {
                Rtotal = R1 + R2 + R3 + R4;
            }
            else if (RadioButtonParallel.Checked)
            {
                Rtotal = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            }
            else
            {
                LabelError.Text = "Select the connection type.";
                return;
            }

            LabelResult.Text = $"Total resistance: {Rtotal:F2} Ohms";
        }
    }
}
