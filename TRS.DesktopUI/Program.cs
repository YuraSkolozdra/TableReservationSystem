using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRS.DesktopUI.Forms;

namespace TRS.DesktopUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoginForm frmLogin = new LoginForm();
            //if (frmLogin.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}

            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message.ToString(), "Error", MessageBoxButtons.OK);
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
