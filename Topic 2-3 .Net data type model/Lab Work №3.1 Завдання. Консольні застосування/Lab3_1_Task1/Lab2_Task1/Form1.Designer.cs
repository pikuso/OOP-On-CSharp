namespace Lab2_Task1
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
            RadioButtonSeries = new RadioButton();
            textBox1 = new TextBox();
            LabelR1 = new Label();
            button1 = new Button();
            LabelR2 = new Label();
            LabelR3 = new Label();
            LabelR4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            RadioButtonParallel = new RadioButton();
            LabelResult = new Label();
            LabelError = new Label();
            SuspendLayout();
            // 
            // RadioButtonSeries
            // 
            RadioButtonSeries.AutoSize = true;
            RadioButtonSeries.Location = new Point(429, 78);
            RadioButtonSeries.Name = "RadioButtonSeries";
            RadioButtonSeries.Size = new Size(55, 19);
            RadioButtonSeries.TabIndex = 0;
            RadioButtonSeries.TabStop = true;
            RadioButtonSeries.Text = "Series";
            RadioButtonSeries.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // LabelR1
            // 
            LabelR1.AutoSize = true;
            LabelR1.Location = new Point(75, 47);
            LabelR1.Name = "LabelR1";
            LabelR1.Size = new Size(20, 15);
            LabelR1.TabIndex = 2;
            LabelR1.Text = "R1";
            // 
            // button1
            // 
            button1.Location = new Point(207, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // LabelR2
            // 
            LabelR2.AutoSize = true;
            LabelR2.Location = new Point(75, 82);
            LabelR2.Name = "LabelR2";
            LabelR2.Size = new Size(20, 15);
            LabelR2.TabIndex = 2;
            LabelR2.Text = "R2";
            // 
            // LabelR3
            // 
            LabelR3.AutoSize = true;
            LabelR3.Location = new Point(75, 119);
            LabelR3.Name = "LabelR3";
            LabelR3.Size = new Size(20, 15);
            LabelR3.TabIndex = 2;
            LabelR3.Text = "R3";
            // 
            // LabelR4
            // 
            LabelR4.AutoSize = true;
            LabelR4.Location = new Point(75, 155);
            LabelR4.Name = "LabelR4";
            LabelR4.Size = new Size(20, 15);
            LabelR4.TabIndex = 2;
            LabelR4.Text = "R4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            // 
            // RadioButtonParallel
            // 
            RadioButtonParallel.AutoSize = true;
            RadioButtonParallel.Location = new Point(429, 112);
            RadioButtonParallel.Name = "RadioButtonParallel";
            RadioButtonParallel.Size = new Size(63, 19);
            RadioButtonParallel.TabIndex = 0;
            RadioButtonParallel.TabStop = true;
            RadioButtonParallel.Text = "Parallel";
            RadioButtonParallel.UseVisualStyleBackColor = true;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(75, 273);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(39, 15);
            LabelResult.TabIndex = 2;
            LabelResult.Text = "Result";
            // 
            // LabelError
            // 
            LabelError.AutoSize = true;
            LabelError.Location = new Point(75, 341);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(32, 15);
            LabelError.TabIndex = 2;
            LabelError.Text = "Error";
            LabelError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LabelError);
            Controls.Add(LabelResult);
            Controls.Add(LabelR4);
            Controls.Add(LabelR3);
            Controls.Add(LabelR2);
            Controls.Add(LabelR1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RadioButtonParallel);
            Controls.Add(RadioButtonSeries);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioButtonSeries;
        private TextBox textBox1;
        private Label LabelR1;
        private Button button1;
        private Label LabelR2;
        private Label LabelR3;
        private Label LabelR4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton RadioButtonParallel;
        private Label LabelResult;
        private Label LabelError;
    }
}
