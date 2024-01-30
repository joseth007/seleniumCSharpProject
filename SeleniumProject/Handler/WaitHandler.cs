using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumProject.Handler
{
    /*
     * Clase para manejar las esperas explicitas
     */
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver Driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch { }

            return false;
        }
    }
}
