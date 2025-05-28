using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class BluetoothPermission
    {
        public ControlHelper controlHelper;
        private  By clicksOk = By.XPath("//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.BluetoothPermission.BluetoothPermissionPlugin.Pages.AllowPermissionPage.PrimaryButtonText\"]");
        private  By allow = By.XPath("//android.widget.Button[@resource-id=\"com.android.permissioncontroller:id/permission_allow_button\"]");
        private  By dontallow = By.XPath("//android.widget.Button[@resource-id=\"com.android.permissioncontroller:id/permission_deny_button\"]");
        public BluetoothPermission() 
        {
            controlHelper = new ControlHelper();
        }
        public void scrollClick(string direction, string key)
        {
            controlHelper.ScrollAndClick(direction, key);
        }
        public void scroll(string direction, string key)
        {
            controlHelper.Scroll(direction, key);
        }
        public void clickOK()
        {
            controlHelper.ButtonClick(clicksOk);
        }
        public void permission(string permission)
        {
            switch (permission.Trim().ToLower())
            {
                case "grant":
                    controlHelper.ButtonClick(allow);
                    break;
                case "deny":
                    controlHelper.ButtonClick(dontallow);
                    break;
                default:
                    throw new ArgumentException($"Unknown permission value: {permission}");
            }
        }
    }
}
