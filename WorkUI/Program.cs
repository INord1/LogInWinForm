using CheckInAndManagmentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckInAndManagmentLibrary.GlobalConfig.InitializeConnacnetion(DataBaseType.sql);
            Application.Run(new LogInPageForm());
        }
    }
}
