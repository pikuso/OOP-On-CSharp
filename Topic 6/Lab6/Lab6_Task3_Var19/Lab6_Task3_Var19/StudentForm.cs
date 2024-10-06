using System;
using System.IO;
using System.Windows.Forms;

namespace Lab6_Task3_Var19
{
    public class StudentForm : Form
    {
        ListBox studentListBox;
        Button loadButton;

        public StudentForm()
        {
            studentListBox = new ListBox() { Width = 300, Height = 200, Top = 10 };
            loadButton = new Button() { Text = "Download students", Top = 220, Width = 300 };
            loadButton.Click += LoadButton_Click;

            Controls.Add(studentListBox);
            Controls.Add(loadButton);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();
            string filePath = "results.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File results.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int score = int.Parse(parts[1]);

                    if (score > 46)
                    {
                        studentListBox.Items.Add($"{name} - {score}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
