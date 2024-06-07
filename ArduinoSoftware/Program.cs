using System;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var sem = new Semaphore(1, 1, "MyApplication"))
            {
                if (sem.WaitOne(500))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.ThreadException += new ThreadExceptionEventHandler(globalErrors);
                    Application.Run(new Form1());
                }
                else 
                {
                    MessageBox.Show("The program is already running","Error");
                }
            }
        }

        private static void globalErrors(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(),"Global error");
        }
    }
}
