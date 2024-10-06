using System;
using System.Windows.Forms;

namespace Lab6_Task3_Var19
{
    static class Program
    {
        [STAThread]
        static void StudentForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentForm()); 
        }
    }
}
