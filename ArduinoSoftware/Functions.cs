using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    internal class Functions
    {
        public bool IsRunningAsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public void RestartAsAdmin()
        {
            var name = Process.GetCurrentProcess().MainModule.FileName;
            var startInfo = new ProcessStartInfo(name) { Verb = "runas" };
            try
            {
                Process.Start(startInfo);
                Application.Exit();
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show
                    (
                    $"An error has occurred.\n Details:\n{ex} \n Try again?",
                    "Error.",
                    buttons: MessageBoxButtons.YesNo
                    );

                if (dr == DialogResult.Yes)
                    RestartAsAdmin();
            }

        }
    }
}
