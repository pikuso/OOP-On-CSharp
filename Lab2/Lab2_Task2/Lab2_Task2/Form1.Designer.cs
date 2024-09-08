namespace Lab2_Task2
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
            TextBoxA = new TextBox();
            LabelA = new Label();
            ButtonCalculate = new Button();
            LabelB = new Label();
            LabelC = new Label();
            LabelR = new Label();
            TextBoxB = new TextBox();
            TextBoxC = new TextBox();
            TextBoxR = new TextBox();
            LabelResult = new Label();
            LabelError = new Label();
            SuspendLayout();
            // 
            // TextBoxA
            // 
            TextBoxA.Location = new Point(250, 46);
            TextBoxA.Name = "TextBoxA";
            TextBoxA.Size = new Size(100, 23);
            TextBoxA.TabIndex = 0;
            // 
            // LabelA
            // 
            LabelA.AutoSize = true;
            LabelA.Location = new Point(76, 49);
            LabelA.Name = "LabelA";
            LabelA.Size = new Size(15, 15);
            LabelA.TabIndex = 1;
            LabelA.Text = "A";
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Location = new Point(263, 264);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(75, 23);
            ButtonCalculate.TabIndex = 2;
            ButtonCalculate.Text = "Calculate";
            ButtonCalculate.UseVisualStyleBackColor = true;
            // 
            // LabelB
            // 
            LabelB.AutoSize = true;
            LabelB.Location = new Point(76, 99);
            LabelB.Name = "LabelB";
            LabelB.Size = new Size(14, 15);
            LabelB.TabIndex = 1;
            LabelB.Text = "B";
            // 
            // LabelC
            // 
            LabelC.AutoSize = true;
            LabelC.Location = new Point(76, 153);
            LabelC.Name = "LabelC";
            LabelC.Size = new Size(15, 15);
            LabelC.TabIndex = 1;
            LabelC.Text = "C";
            // 
            // LabelR
            // 
            LabelR.AutoSize = true;
            LabelR.Location = new Point(76, 196);
            LabelR.Name = "LabelR";
            LabelR.Size = new Size(14, 15);
            LabelR.TabIndex = 1;
            LabelR.Text = "R";
            // 
            // TextBoxB
            // 
            TextBoxB.Location = new Point(250, 96);
            TextBoxB.Name = "TextBoxB";
            TextBoxB.Size = new Size(100, 23);
            TextBoxB.TabIndex = 0;
            // 
            // TextBoxC
            // 
            TextBoxC.Location = new Point(250, 150);
            TextBoxC.Name = "TextBoxC";
            TextBoxC.Size = new Size(100, 23);
            TextBoxC.TabIndex = 0;
            // 
            // TextBoxR
            // 
            TextBoxR.Location = new Point(250, 196);
            TextBoxR.Name = "TextBoxR";
            TextBoxR.Size = new Size(100, 23);
            TextBoxR.TabIndex = 0;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(76, 321);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(39, 15);
            LabelResult.TabIndex = 1;
            LabelResult.Text = "Result";
            // 
            // LabelError
            // 
            LabelError.AutoSize = true;
            LabelError.Location = new Point(76, 377);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(32, 15);
            LabelError.TabIndex = 1;
            LabelError.Text = "Error";
            LabelError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCalculate);
            Controls.Add(LabelError);
            Controls.Add(LabelResult);
            Controls.Add(LabelR);
            Controls.Add(LabelC);
            Controls.Add(LabelB);
            Controls.Add(LabelA);
            Controls.Add(TextBoxR);
            Controls.Add(TextBoxC);
            Controls.Add(TextBoxB);
            Controls.Add(TextBoxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxA;
        private Label LabelA;
        private Button ButtonCalculate;
        private Label LabelB;
        private Label LabelC;
        private Label LabelR;
        private TextBox TextBoxB;
        private TextBox TextBoxC;
        private TextBox TextBoxR;
        private Label LabelResult;
        private Label LabelError;
    }
}
