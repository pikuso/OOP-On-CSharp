namespace WinFormsApp2_Task2
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
            Button2 = new Button();
            Label2 = new Label();
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.Location = new Point(155, 94);
            Button2.Name = "Button2";
            Button2.Size = new Size(203, 23);
            Button2.TabIndex = 0;
            Button2.Text = "Print the maximum elements";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 156);
            Label2.Name = "Label2";
            Label2.Size = new Size(38, 15);
            Label2.TabIndex = 1;
            Label2.Text = "label1";
            Label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 392);
            Controls.Add(Label2);
            Controls.Add(Button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button2;
        private Label Label2;
    }
}
