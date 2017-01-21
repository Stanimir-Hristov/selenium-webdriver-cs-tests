using OpenQA.Selenium;
using System.Threading;

namespace Tests
{
    public class Utilities
    {
        public static void Waiting(int seconds)
        {
		// some try
            seconds *= 1000;
            Thread.Sleep(seconds);
        }
        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
    }
}
