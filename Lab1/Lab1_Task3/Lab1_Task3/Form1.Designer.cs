namespace Lab1_Task3
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
            PicSign = new PictureBox();
            label1 = new Label();
            buttonShowGreeting = new Button();
            textBoxName = new TextBox();
            labelGreeting = new Label();
            ((System.ComponentModel.ISupportInitialize)PicSign).BeginInit();
            SuspendLayout();
            // 
            // PicSign
            // 
            PicSign.Image = Properties.Resources.Zelensky_sign;
            PicSign.Location = new Point(364, 145);
            PicSign.Name = "PicSign";
            PicSign.Size = new Size(424, 305);
            PicSign.TabIndex = 0;
            PicSign.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 63);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your name";
            // 
            // buttonShowGreeting
            // 
            buttonShowGreeting.Location = new Point(313, 116);
            buttonShowGreeting.Name = "buttonShowGreeting";
            buttonShowGreeting.Size = new Size(174, 23);
            buttonShowGreeting.TabIndex = 2;
            buttonShowGreeting.Text = "Show Greeting ";
            buttonShowGreeting.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(344, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Location = new Point(78, 145);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(55, 15);
            labelGreeting.TabIndex = 1;
            labelGreeting.Text = "Greeting!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxName);
            Controls.Add(buttonShowGreeting);
            Controls.Add(labelGreeting);
            Controls.Add(label1);
            Controls.Add(PicSign);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PicSign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicSign;
        private Label label1;
        private Button buttonShowGreeting;
        private TextBox textBoxName;
        private Label labelGreeting;
    }
}
