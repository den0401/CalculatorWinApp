using Aquality.WinAppDriver.Actions;
using Aquality.WinAppDriver.Forms;
using System;

namespace CalculatorWinApp.Utils
{
    public static class AppUtils
    {
        public static void SwitchToView(Form form, string view)
        {
            if (view == ConfigUtils.GetConfigProperties("standardView"))
            {
                form.KeyboardActions.SendKeysWithKeyHold("1", ModifierKey.Alt);
            }
            else if (view == ConfigUtils.GetConfigProperties("scientificView"))
            {
                form.KeyboardActions.SendKeysWithKeyHold("2", ModifierKey.Alt);
            }
            else
                throw new ArgumentException($"{view} is not allowed calculator view");
        }
    }
}