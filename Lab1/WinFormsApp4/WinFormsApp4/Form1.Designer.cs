namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxImages = new ListBox();
            pictureBoxImage = new PictureBox();
            buttonLoadImages = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // listBoxImages
            // 
            listBoxImages.FormattingEnabled = true;
            listBoxImages.ItemHeight = 15;
            listBoxImages.Location = new Point(408, 124);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.Size = new Size(120, 94);
            listBoxImages.TabIndex = 0;
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(418, 337);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(100, 50);
            pictureBoxImage.TabIndex = 1;
            pictureBoxImage.TabStop = false;
            // 
            // buttonLoadImages
            // 
            buttonLoadImages.Location = new Point(387, 461);
            buttonLoadImages.Name = "buttonLoadImages";
            buttonLoadImages.Size = new Size(163, 23);
            buttonLoadImages.TabIndex = 2;
            buttonLoadImages.Text = "Загрузить изображения";
            buttonLoadImages.UseVisualStyleBackColor = true;
            buttonLoadImages.Click += buttonLoadImages_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 646);
            Controls.Add(buttonLoadImages);
            Controls.Add(pictureBoxImage);
            Controls.Add(listBoxImages);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxImages;
        private PictureBox pictureBoxImage;
        private Button buttonLoadImages;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
