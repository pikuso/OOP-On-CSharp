namespace Lab1_Task1
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
            calculateButton = new Button();
            textBoxB = new TextBox();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            textBoxC = new TextBox();
            textBoxA = new TextBox();
            textBoxResultSideA = new TextBox();
            textBoxResultAngleC = new TextBox();
            textBoxResultSideB = new TextBox();
            labelResultAngleC = new Label();
            labelResultSideA = new Label();
            labelResultSideB = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(182, 184);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(169, 78);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 1;
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(62, 40);
            labelA.Name = "labelA";
            labelA.Size = new Size(49, 15);
            labelA.TabIndex = 2;
            labelA.Text = "Angle A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(62, 86);
            labelB.Name = "labelB";
            labelB.Size = new Size(48, 15);
            labelB.TabIndex = 2;
            labelB.Text = "Angle B";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(62, 131);
            labelC.Name = "labelC";
            labelC.Size = new Size(38, 15);
            labelC.TabIndex = 2;
            labelC.Text = "Side c";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(169, 123);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 1;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(169, 32);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 1;
            // 
            // textBoxResultSideA
            // 
            textBoxResultSideA.Location = new Point(169, 302);
            textBoxResultSideA.Name = "textBoxResultSideA";
            textBoxResultSideA.Size = new Size(100, 23);
            textBoxResultSideA.TabIndex = 1;
            // 
            // textBoxResultAngleC
            // 
            textBoxResultAngleC.Location = new Point(169, 256);
            textBoxResultAngleC.Name = "textBoxResultAngleC";
            textBoxResultAngleC.Size = new Size(100, 23);
            textBoxResultAngleC.TabIndex = 1;
            // 
            // textBoxResultSideB
            // 
            textBoxResultSideB.Location = new Point(169, 347);
            textBoxResultSideB.Name = "textBoxResultSideB";
            textBoxResultSideB.Size = new Size(100, 23);
            textBoxResultSideB.TabIndex = 1;
            // 
            // labelResultAngleC
            // 
            labelResultAngleC.AutoSize = true;
            labelResultAngleC.Location = new Point(62, 264);
            labelResultAngleC.Name = "labelResultAngleC";
            labelResultAngleC.Size = new Size(65, 15);
            labelResultAngleC.TabIndex = 2;
            labelResultAngleC.Text = "Angle C (°)";
            // 
            // labelResultSideA
            // 
            labelResultSideA.AutoSize = true;
            labelResultSideA.Location = new Point(62, 310);
            labelResultSideA.Name = "labelResultSideA";
            labelResultSideA.Size = new Size(75, 15);
            labelResultSideA.TabIndex = 2;
            labelResultSideA.Text = "Side a (units)";
            // 
            // labelResultSideB
            // 
            labelResultSideB.AutoSize = true;
            labelResultSideB.Location = new Point(62, 355);
            labelResultSideB.Name = "labelResultSideB";
            labelResultSideB.Size = new Size(79, 15);
            labelResultSideB.TabIndex = 2;
            labelResultSideB.Text = "Side b (units):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultSideB);
            Controls.Add(labelC);
            Controls.Add(labelResultSideA);
            Controls.Add(labelB);
            Controls.Add(labelResultAngleC);
            Controls.Add(labelA);
            Controls.Add(textBoxResultSideB);
            Controls.Add(textBoxResultAngleC);
            Controls.Add(textBoxC);
            Controls.Add(textBoxResultSideA);
            Controls.Add(textBoxA);
            Controls.Add(textBoxB);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox textBoxB;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private TextBox textBoxC;
        private TextBox textBoxA;
        private TextBox textBoxResultSideA;
        private TextBox textBoxResultAngleC;
        private TextBox textBoxResultSideB;
        private Label labelResultAngleC;
        private Label labelResultSideA;
        private Label labelResultSideB;
    }
}
