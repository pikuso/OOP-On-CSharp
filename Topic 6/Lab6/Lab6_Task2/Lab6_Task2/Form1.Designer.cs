namespace Lab6_Task2
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
            firstNameBox = new TextBox();
            birthYearBox = new TextBox();
            lastNameBox = new TextBox();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(202, 114);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(108, 23);
            firstNameBox.TabIndex = 0;
            firstNameBox.TextChanged += textBox1_TextChanged;
            // 
            // birthYearBox
            // 
            birthYearBox.Location = new Point(202, 155);
            birthYearBox.Name = "birthYearBox";
            birthYearBox.Size = new Size(88, 23);
            birthYearBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(202, 72);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(119, 23);
            lastNameBox.TabIndex = 0;
            lastNameBox.TextChanged += textBox1_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(171, 213);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 80);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Surname:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 163);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Date of birth:";
            label3.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 396);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(birthYearBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameBox;
        private TextBox birthYearBox;
        private TextBox lastNameBox;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
