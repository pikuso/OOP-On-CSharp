namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelError.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelError.Text = "";

            string programName = textBoxProgramName.Text.Trim();
            string date1 = textBoxDate1.Text.Trim();
            string date2 = textBoxDate2.Text.Trim();

            if (string.IsNullOrEmpty(programName))
            {
                ShowError("Please, enter the name of the TV show.");
                return;
            }

            if (!IsValidDate(date1))
            {
                ShowError("Invalid date format for 'Date 1'. Enter the date in the format DD.MM.RRRR.");
                return;
            }

            if (!IsValidDate(date2))
            {
                ShowError("Invalid date format for 'Date 2'. Enter the date in the format DD.MM.RRRR.");
                return;
            }

            DateTime dateTime1 = DateTime.ParseExact(date1, "dd.MM.yyyy", null);
            DateTime dateTime2 = DateTime.ParseExact(date2, "dd.MM.yyyy", null);

            if (dateTime2 < dateTime1)
            {
                ShowError("The new date ('Date 2') cannot be earlier than the original date ('Date 1').");
                return;
            }

            string message = $"Dear viewers!\n\n" +
                             $"For technical reasons, the program is broadcast under the name \"{programName}\" transferred from {date1} on {date2}.\n" +
                             "We apologize for the inconvenience caused.\n\n" +
                             "Directorate of the TV channel";
            MessageBox.Show(message, "Advertisement");
        }

        private void ShowError(string errorMessage)
        {
            labelError.Text = errorMessage;
            labelError.Visible = true;
        }

        private bool IsValidDate(string date)
        {
            DateTime tempDate;
            return DateTime.TryParseExact(date, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out tempDate);
        }
    }
}
