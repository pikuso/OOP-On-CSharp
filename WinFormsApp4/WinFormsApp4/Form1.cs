using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderDialog;

        public Form1()
        {
            InitializeComponent();
            folderDialog = new FolderBrowserDialog();
        }

        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                listBoxImages.Items.Clear();

                string[] files = Directory.GetFiles(selectedPath, "*.jpg");

                if (files.Length == 0)
                {
                    MessageBox.Show("The selected folder does not contain any JPG images.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (string file in files)
                    {
                        listBoxImages.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex >= 0)
            {
                string selectedFileName = listBoxImages.SelectedItem.ToString();
                string folderPath = folderDialog.SelectedPath;
                string imagePath = Path.Combine(folderPath, selectedFileName);

                try
                {
                    if (File.Exists(imagePath))
                    {
                        pictureBoxImage.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("Failed to load image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
