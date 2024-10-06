using System;

namespace Example1
{
    public partial class MakeLineForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltResults.Text = "<div style='color:red'>" + MakeLine(5, ", ", 10) + "</div><br/>";
            ltResults.Text += "<div style='color:blue'>" + MakeLine(6, " ", 5) + "</div><br/>";
            ltResults.Text += "<div style='color:green'>" + MakeLine(9, ": ", 11) + "</div><br/>";
            ltResults.Text += "<div style='color:brown'>" + MakeLine(7, "< ", 12) + "</div><br/>";
        }

        private static string MakeLine(int number, string separator, int count)
        {
            string[] sArr = new string[count];
            for (int i = 0; i < count; i++)
            {
                sArr[i] = (i * number).ToString();
            }
            return string.Join(separator, sArr);
        }
    }
}
