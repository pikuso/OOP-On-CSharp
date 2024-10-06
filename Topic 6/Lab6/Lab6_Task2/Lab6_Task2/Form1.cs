using System;
using System.IO;
using System.Windows.Forms;

namespace Lab6_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveButton.Click += SaveButton_Click; 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string data = $"Name: {lastNameBox.Text}, Name: {firstNameBox.Text}, Year of birth: {birthYearBox.Text}";

            try
            {
                File.WriteAllText("lab6.txt", data);
                MessageBox.Show("Data saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
