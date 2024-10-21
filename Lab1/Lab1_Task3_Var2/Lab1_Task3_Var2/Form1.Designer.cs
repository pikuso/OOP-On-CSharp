namespace Lab1_Task3_Var2
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
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            textBoxProfession = new TextBox();
            buttonSubmit = new Button();
            dataGridViewOutput = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(181, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(181, 74);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 1;
            // 
            // textBoxProfession
            // 
            textBoxProfession.Location = new Point(181, 127);
            textBoxProfession.Name = "textBoxProfession";
            textBoxProfession.Size = new Size(100, 23);
            textBoxProfession.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(192, 183);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "button1";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Location = new Point(45, 234);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.Size = new Size(415, 150);
            dataGridViewOutput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 82);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 135);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Profession:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 506);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridViewOutput);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxProfession);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxProfession;
        private Button buttonSubmit;
        private DataGridView dataGridViewOutput;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
