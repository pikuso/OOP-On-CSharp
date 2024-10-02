namespace MainForm_Lab3_2_Task3_1._1_
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
            txtSurfaceArea = new TextBox();
            btnCalculate = new Button();
            btnClose = new Button();
            txtVolume = new TextBox();
            lblSurfaceArea = new Label();
            lblVolume = new Label();
            SuspendLayout();
            // 
            // txtSurfaceArea
            // 
            txtSurfaceArea.Location = new Point(181, 52);
            txtSurfaceArea.Name = "txtSurfaceArea";
            txtSurfaceArea.ReadOnly = true;
            txtSurfaceArea.Size = new Size(100, 23);
            txtSurfaceArea.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(112, 180);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 23);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(94, 228);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(181, 104);
            txtVolume.Name = "txtVolume";
            txtVolume.ReadOnly = true;
            txtVolume.Size = new Size(100, 23);
            txtVolume.TabIndex = 0;
            // 
            // lblSurfaceArea
            // 
            lblSurfaceArea.AutoSize = true;
            lblSurfaceArea.Location = new Point(22, 52);
            lblSurfaceArea.Name = "lblSurfaceArea";
            lblSurfaceArea.Size = new Size(126, 15);
            lblSurfaceArea.TabIndex = 2;
            lblSurfaceArea.Text = "Поле площі поверхні";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(22, 104);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(77, 15);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Поле об'єму";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVolume);
            Controls.Add(lblSurfaceArea);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(txtVolume);
            Controls.Add(txtSurfaceArea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSurfaceArea;
        private Button btnCalculate;
        private Button btnClose;
        private TextBox txtVolume;
        private Label lblSurfaceArea;
        private Label lblVolume;
    }
}
