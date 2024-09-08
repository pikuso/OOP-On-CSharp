using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ButtonCalculate.Click += ButtonCalculate_Click;

            LabelError.Visible = false;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            LabelError.Text = string.Empty;
            LabelError.Visible = false;

            double A, B, C, R;

            if (!double.TryParse(TextBoxA.Text, out A) || A <= 0 ||
            !double.TryParse(TextBoxB.Text, out B) || B <= 0 ||
            !double.TryParse(TextBoxC.Text, out C) || C <= 0 ||
                !double.TryParse(TextBoxR.Text, out R) || R <= 0)
            {
                ShowError("Please enter valid positive values for all angles and radius.");
                return;
            }

            if (Math.Abs(A + B + C - 180) > 0.01)
            {
                ShowError("The sum of the angles must be equal to 180 degrees.");
                return;
            }

            try
            {
                double A_rad = Math.PI * A / 180;
                double B_rad = Math.PI * B / 180;
                double C_rad = Math.PI * C / 180;

                A = 2 * R * Math.Sin(A_rad);
                B = 2 * R * Math.Sin(B_rad);
                C = 2 * R * Math.Sin(C_rad);

                if (double.IsNaN(A) || double.IsNaN(B) || double.IsNaN(C))
                {
                    ShowError("Unable to calculate the sides of the triangle. Please check your input.");
                    return;
                }

                LabelResult.Text = $"Sides of a triangle: a = {A:F2}, b = {B:F2}, c = {C:F2}";
            }
            catch (Exception)
            {
                ShowError("An error occurred while calculating the sides of the triangle.");
            }
        }

        private void ShowError(string message)
        {
            LabelError.Text = message;
            LabelError.Visible = true;
        }
    }
}
