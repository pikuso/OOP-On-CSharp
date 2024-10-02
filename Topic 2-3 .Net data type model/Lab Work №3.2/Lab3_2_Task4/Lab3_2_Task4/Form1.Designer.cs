namespace Lab3_2_Task4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtReversed = new TextBox();
            labelMessage = new Label();
            txtFileName = new TextBox();
            btnSave = new Button();
            btnLoad = new Button();
            txtCharCount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(281, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(408, 42);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(130, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtReversed
            // 
            txtReversed.Location = new Point(291, 139);
            txtReversed.Name = "txtReversed";
            txtReversed.ReadOnly = true;
            txtReversed.Size = new Size(247, 23);
            txtReversed.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(23, 350);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(144, 15);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Кількість символів рядка";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(37, 139);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(130, 23);
            txtFileName.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(330, 84);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(343, 199);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(149, 23);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtCharCount
            // 
            txtCharCount.Location = new Point(173, 347);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.ReadOnly = true;
            txtCharCount.Size = new Size(197, 23);
            txtCharCount.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 3;
            label1.Text = "введення користувачем прізвища та ім'я";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(labelMessage);
            Controls.Add(txtCharCount);
            Controls.Add(txtFileName);
            Controls.Add(txtReversed);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        // Other auto-generated code omitted for brevity

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtReversed;
        private Label labelMessage; // Changed name from Label
        private TextBox txtFileName;
        private Button btnSave;
        private Button btnLoad;
        private TextBox txtCharCount;
        private Label label1;
    }
}
