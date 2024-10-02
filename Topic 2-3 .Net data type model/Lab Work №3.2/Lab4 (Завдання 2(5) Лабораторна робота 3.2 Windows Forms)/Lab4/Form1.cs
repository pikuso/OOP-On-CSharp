using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxImages.Items.Clear();

                    string selectedFolder = folderDialog.SelectedPath;

                    string[] imageFiles = Directory.GetFiles(selectedFolder, "*.*")
                        .Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("bmp"))
                        .ToArray();

                    foreach (string file in imageFiles)
                    {
                        listBoxImages.Items.Add(file);
                    }
                }
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedItem != null)
            {
                string selectedImagePath = listBoxImages.SelectedItem.ToString();

                pictureBox.Image = Image.FromFile(selectedImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
