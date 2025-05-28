using BluetoothPermission.Drivers;
using BluetoothPermission.Namespaces;
using OpenQA.Selenium;
using Reqnroll;
using Reqnroll.BoDi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetoothPermission.Pages
{
    public class BluetoothPermissionPluginPage
    {
        private Pagebase pagebase;

        //public BluetoothPermissionPluginPage() 
        //{
        //    pagebase = new Pagebase();
        //}
     
        public IWebElement FindElement(string elementName) =>
            drivers.driver1.FindElementByXPath(GetAutomationID(elementName));
        public void clickelement(string elementName) =>
           drivers.driver1.FindElementByXPath(GetAutomationID(elementName)).Click();

        public string GetAutomationID(string elementName)
        {
            return elementName switch
            {
                "Ok" => $"{NAPNamespaces.BluetoothPermissionPluginNamespace}.AllowPermissionPage.PrimaryButtonText']",
                "BluetoothPermissionHeader" => $"{NAPNamespaces.BluetoothPermissionTextview}.AllowPermissionPage.Header']",
                "Bluetooth permission app settings header" => $"{NAPNamespaces.BluetoothPermissionTextview}.AllowPermissionFromAppSettingsPage.Header']",
                "BluetoothPermissionBody" => $"{NAPNamespaces.BluetoothPermissionTextview}.AllowPermissionPage.Body1']",
                "OpenSettings" => $"{NAPNamespaces.BluetoothPermissionPluginNamespace}.AllowPermissionFromAppSettingsPage.PrimaryButtonText']",
                "OpenSettingsPermissionHeader" => $"{NAPNamespaces.BluetoothPermissionPluginNamespace}.AllowPermissionFromAppSettingsPage.Header']",
                "OpenSettingsPermissionBody" => $"{NAPNamespaces.BluetoothPermissionTextview}.AllowPermissionFromAppSettingsPage.Body1']",
                "Deny" => $"{NAPNamespaces.permissionbuttons}:id/permission_deny_button']",
                "Grant" => $"{NAPNamespaces.permissionbuttons}:id/permission_allow_button']",
                "NativeSettingsDeny" => "//android.widget.RadioButton[@resource-id='com.android.permissioncontroller:id/deny_radio_button']",
                "NativeSettingsAllow" => "//android.widget.FrameLayout[@resource-id='com.android.permissioncontroller:id/allow_radio_button_frame']",
                "Search" => "//android.widget.AutoCompleteTextView[@resource-id='com.ReSound.TestMultiplePlugins:id/search_src_text']",
                "Permissions" => "//androidx.recyclerview.widget.RecyclerView[@resource-id='com.android.settings:id/recycler_view']/android.widget.LinearLayout[2]/android.widget.RelativeLayout",

                _ => throw new Exception($"{elementName} is NOT supported")
            };
        }
    }
}
