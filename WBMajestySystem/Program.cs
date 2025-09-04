using System;
using System.Windows.Forms;

namespace WBMajestySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.ThreadException += (s, e) => MessageBox.Show(e.Exception.ToString(), "ThreadException");
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                MessageBox.Show(((Exception)e.ExceptionObject).ToString(), "UnhandledException");
            Application.Run(new LoginForm()); // <- must be LoginForm
        }
    }
}