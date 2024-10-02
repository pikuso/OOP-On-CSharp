namespace FormsApp3_0_Task2
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
            textBoxX1 = new TextBox();
            textBoxX2 = new TextBox();
            textBoxY1 = new TextBox();
            button1_Click = new Button();
            textBoxY2 = new TextBox();
            textBoxX3 = new TextBox();
            textBoxY3 = new TextBox();
            labelArea = new Label();
            SuspendLayout();
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(27, 35);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 0;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(27, 142);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(100, 23);
            textBoxX2.TabIndex = 0;
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(27, 90);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(100, 23);
            textBoxY1.TabIndex = 0;
            // 
            // button1_Click
            // 
            button1_Click.Location = new Point(41, 401);
            button1_Click.Name = "button1_Click";
            button1_Click.Size = new Size(75, 23);
            button1_Click.TabIndex = 1;
            button1_Click.Text = "button1";
            button1_Click.UseVisualStyleBackColor = true;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(27, 198);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(100, 23);
            textBoxY2.TabIndex = 0;
            // 
            // textBoxX3
            // 
            textBoxX3.Location = new Point(27, 253);
            textBoxX3.Name = "textBoxX3";
            textBoxX3.Size = new Size(100, 23);
            textBoxX3.TabIndex = 0;
            // 
            // textBoxY3
            // 
            textBoxY3.Location = new Point(27, 300);
            textBoxY3.Name = "textBoxY3";
            textBoxY3.Size = new Size(100, 23);
            textBoxY3.TabIndex = 0;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(452, 35);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(115, 15);
            labelArea.TabIndex = 2;
            labelArea.Text = "Площа трикутника:";
            labelArea.Click += labelArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelArea);
            Controls.Add(button1_Click);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxY3);
            Controls.Add(textBoxX3);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxX1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX1;
        private TextBox textBoxX2;
        private TextBox textBoxY1;
        private Button button1_Click;
        private TextBox textBoxY2;
        private TextBox textBoxX3;
        private TextBox textBoxY3;
        private Label labelArea;
    }
}
