using Microsoft.Win32;
using System.Windows.Forms;

namespace ArduinoSoftware
{
    public class Reg
    {
        public string regKey = "ArduinoSoft";
        public string regIsHide = "isHide";
        public string regIsAutoRun = "isAutoRun";
        public string autoRunPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        public string autoRunKeyName = "clean";


        public bool getRegIsHide()
        {
            var currentUserKey = Registry.CurrentUser;
            var rkHide = currentUserKey.OpenSubKey(regKey);
            if (rkHide.GetValue(regIsHide).ToString() == "1") return true;
            return false;
        }

        public bool getRegIsAutoRun()
        {
            RegistryKey rkAuto = Registry.CurrentUser.OpenSubKey(autoRunPath, true);
            object cleanValue = rkAuto.GetValue(autoRunKeyName);
            if (cleanValue != null && cleanValue.ToString() != "0")
            {
                return true;
            }
            return false;
        }

        public void setRegIsAutoRun(bool isEnabled)
        {
            RegistryKey rkAuto = Registry.CurrentUser.OpenSubKey(autoRunPath, true);
            if (isEnabled)
            {
                rkAuto.SetValue(autoRunKeyName, Application.ExecutablePath + " /hide");
            }
            else
            {
                rkAuto.DeleteValue(autoRunKeyName, false);
            }
        }

        public void setRegIsHide(bool isEnabled)
        {
            var currentUserKey = Registry.CurrentUser;
            var rkHide = currentUserKey.OpenSubKey(regKey, true);
            if (isEnabled)
            {
                rkHide.SetValue(regIsHide, 1);
            }
            else
            {
                rkHide.SetValue(regIsHide, 0);
            }
        }

        public void checkRegKey()
        {
            var rkHide = Registry.CurrentUser.OpenSubKey(regKey, true);
            if (rkHide == null)
            {
                Registry.CurrentUser.CreateSubKey(regKey, true).Close();
                rkHide = Registry.CurrentUser.OpenSubKey(regKey, true);
            }

            if (rkHide.GetValue(regIsHide) == null) rkHide.SetValue(regIsHide, 0);
        }
    }
}
