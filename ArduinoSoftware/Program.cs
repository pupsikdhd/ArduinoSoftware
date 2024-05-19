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
                    Application.Run(new Form1());
                }
                else 
                {
                    MessageBox.Show("The program is already running","Error");
                }
            }
        }
    }
}
