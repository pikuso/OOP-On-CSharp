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
            textBoxProgramName = new TextBox();
            textBoxDate1 = new TextBox();
            textBoxDate2 = new TextBox();
            labelProgramName = new Label();
            labelDate1 = new Label();
            labelDate2 = new Label();
            buttonSubmit = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(246, 36);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(100, 23);
            textBoxProgramName.TabIndex = 0;
            // 
            // textBoxDate1
            // 
            textBoxDate1.Location = new Point(161, 82);
            textBoxDate1.Name = "textBoxDate1";
            textBoxDate1.Size = new Size(100, 23);
            textBoxDate1.TabIndex = 0;
            // 
            // textBoxDate2
            // 
            textBoxDate2.Location = new Point(161, 125);
            textBoxDate2.Name = "textBoxDate2";
            textBoxDate2.Size = new Size(100, 23);
            textBoxDate2.TabIndex = 0;
            // 
            // labelProgramName
            // 
            labelProgramName.AutoSize = true;
            labelProgramName.Location = new Point(74, 39);
            labelProgramName.Name = "labelProgramName";
            labelProgramName.Size = new Size(154, 15);
            labelProgramName.TabIndex = 1;
            labelProgramName.Text = "Введіть назву телепередачі";
            // 
            // labelDate1
            // 
            labelDate1.AutoSize = true;
            labelDate1.Location = new Point(74, 85);
            labelDate1.Name = "labelDate1";
            labelDate1.Size = new Size(81, 15);
            labelDate1.TabIndex = 1;
            labelDate1.Text = "Введіть дату 1";
            // 
            // labelDate2
            // 
            labelDate2.AutoSize = true;
            labelDate2.Location = new Point(74, 128);
            labelDate2.Name = "labelDate2";
            labelDate2.Size = new Size(81, 15);
            labelDate2.TabIndex = 1;
            labelDate2.Text = "Введіть дату 2";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(246, 187);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 28);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Підтвердити";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(74, 279);
            labelError.Name = "labelError";
            labelError.Size = new Size(32, 15);
            labelError.TabIndex = 1;
            labelError.Text = "Error";
            labelError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 445);
            Controls.Add(buttonSubmit);
            Controls.Add(labelError);
            Controls.Add(labelDate2);
            Controls.Add(labelDate1);
            Controls.Add(labelProgramName);
            Controls.Add(textBoxDate2);
            Controls.Add(textBoxDate1);
            Controls.Add(textBoxProgramName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramName;
        private TextBox textBoxDate1;
        private TextBox textBoxDate2;
        private Label labelProgramName;
        private Label labelDate1;
        private Label labelDate2;
        private Button buttonSubmit;
        private Label labelError;
    }
}
