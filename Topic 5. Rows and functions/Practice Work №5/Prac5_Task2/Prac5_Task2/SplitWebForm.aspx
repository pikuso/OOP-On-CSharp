using System;

namespace Example2
{
    public partial class SplitWebForm : System.Web.UI.Page
    {
        // Символи для розділення
        char[] delimiters = new char[] { ';', ',', ' ', '\n', '\t' };

        protected void btnSplit_Click(object sender, EventArgs e)
        {
            string input = txtString.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                ltrResult.Text = "<b>Результат розділення:</b><br/>";
                foreach (string part in parts)
                {
                    ltrResult.Text += part + "<br/>";
                }
            }
        }
    }
}
