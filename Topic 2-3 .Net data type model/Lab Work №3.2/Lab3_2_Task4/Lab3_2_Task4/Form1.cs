using System;
using System.IO;
using System.Windows.Forms;

namespace Lab3_2_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string reversed = lastName + " " + firstName;
            txtReversed.Text = reversed;

            int charCount = (firstName + lastName).Length;
            txtCharCount.Text = charCount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("??????????, ??????? ??? ?????.");
                return;
            }

            string content = txtFirstName.Text + " " + txtLastName.Text;

            try
            {
                File.WriteAllText(fileName, content);
                MessageBox.Show("???? ??????? ????????.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"????????? ?????? ??? ?????????? ?????: {ex.Message}");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("??????????, ??????? ??? ?????.");
                return;
            }

            if (File.Exists(fileName))
            {
                try
                {
                    string content = File.ReadAllText(fileName);
                    txtReversed.Text = content;
                    MessageBox.Show("???? ??????? ????????.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"????????? ?????? ??? ???????? ?????: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("???? ?? ??????.");
            }
        }

        
    }
}
