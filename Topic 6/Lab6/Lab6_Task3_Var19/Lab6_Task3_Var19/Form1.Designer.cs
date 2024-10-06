using Lab6_Task3_Var19;
using System;
using System.Windows.Forms;

namespace Lab6_Task
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Example to run the PersonalInfoForm
            Application.Run(new StudentForm());
            // Or to run the StudentForm
            // Application.Run(new StudentForm());
        }
    }
}
