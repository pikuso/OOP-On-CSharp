namespace Lab4
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
            pictureBox = new PictureBox();
            btnOpenFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // listBoxImages
            // 
            listBoxImages.FormattingEnabled = true;
            listBoxImages.ItemHeight = 15;
            listBoxImages.Location = new Point(282, 12);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.Size = new Size(193, 139);
            listBoxImages.TabIndex = 0;
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(245, 172);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(260, 129);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Location = new Point(306, 335);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(129, 23);
            btnOpenFolder.TabIndex = 2;
            btnOpenFolder.Text = "Click to open folder!";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenFolder);
            Controls.Add(pictureBox);
            Controls.Add(listBoxImages);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxImages;
        private PictureBox pictureBox;
        private Button btnOpenFolder;
    }
}
