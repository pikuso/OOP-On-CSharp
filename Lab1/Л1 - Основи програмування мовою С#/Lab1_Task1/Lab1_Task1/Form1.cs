using System;
using System.Windows.Forms;

namespace Lab1_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculateButton.Click += calculateButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double angleA;
                double angleB;
                double sideC;

                if (!double.TryParse(textBoxA.Text, out angleA))
                {
                    MessageBox.Show("Angle A must be a number.");
                    return;
                }

                if (!double.TryParse(textBoxB.Text, out angleB))
                {
                    MessageBox.Show("Angle B must be a number.");
                    return;
                }

                if (!double.TryParse(textBoxC.Text, out sideC))
                {
                    MessageBox.Show("Side c must be a number.");
                    return;
                }

                if (angleA <= 0)
                {
                    MessageBox.Show("Angle A must be a positive number.");
                    return;
                }

                if (angleB <= 0)
                {
                    MessageBox.Show("Angle B must be a positive number.");
                    return;
                }

                if (angleA + angleB >= 180)
                {
                    MessageBox.Show("The sum of angles A and B must be less than 180°.");
                    return;
                }

                if (sideC <= 0)
                {
                    MessageBox.Show("Side c must be a positive number.");
                    return;
                }

                double angleC = 180 - angleA - angleB;
                double angleARad = angleA * Math.PI / 180;
                double angleBRad = angleB * Math.PI / 180;
                double angleCRad = angleC * Math.PI / 180;

                double sideA = (sideC * Math.Sin(angleARad)) / Math.Sin(angleCRad);
                double sideB = (sideC * Math.Sin(angleBRad)) / Math.Sin(angleCRad);

                textBoxResultAngleC.Text = angleC.ToString("F2");
                textBoxResultSideA.Text = sideA.ToString("F2");
                textBoxResultSideB.Text = sideB.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
