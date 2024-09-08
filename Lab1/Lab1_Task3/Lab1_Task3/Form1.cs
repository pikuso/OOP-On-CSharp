using System;
using System.Windows.Forms;

namespace Lab1_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Attach the event handler to the button
            buttonShowGreeting.Click += buttonShowGreeting_Click;
        }

        private void buttonShowGreeting_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name to receive a greeting.");
                return;
            }

            string greeting = $"Dear {name}!" + Environment.NewLine + Environment.NewLine +
                              "Happy Birthday!" + Environment.NewLine +
                              "Wishing you health, happiness, and success!" + Environment.NewLine + Environment.NewLine +
                              "Best regards," + Environment.NewLine +
                              "The President of Ukraine";

            labelGreeting.Text = greeting;
        }
    }
}
