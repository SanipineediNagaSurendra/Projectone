using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMultiplePlugins.Utilities;

namespace TestMultiplePlugins.Pages
{
    public class Complex
    {
        public ControlHelper controlHelper;
        public static Verify _verify = new Verify();
        public Complex() 
        {
            controlHelper = new ControlHelper();
        }
        public void verify(string text, string page)
        {
            if (page.Contains("left"))
            {
                _verify.verify(text);
            }
            else if (page.Contains("right")) 
            {
                _verify.Verifyy(text);
            }
        }
    }
}
