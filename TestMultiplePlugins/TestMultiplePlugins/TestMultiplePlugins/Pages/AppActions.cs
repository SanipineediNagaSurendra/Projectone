using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class AppActions
    {
        public void relaunchapp()
        {
            drivers._driver.TerminateApp("com.ReSound.TestMultiplePlugins");
            drivers._driver.ActivateApp("com.ReSound.TestMultiplePlugins");
        }
        public void launchsettings()
        {
            drivers._driver.ActivateApp("com.android.settings");
        }
        public void launchapp()
        {
            drivers._driver.ActivateApp("com.ReSound.TestMultiplePlugins");
        }
    }
}
