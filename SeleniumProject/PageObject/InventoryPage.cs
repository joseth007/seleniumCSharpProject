using OpenQA.Selenium;
using SeleniumProject.Handler;
using System;

namespace SeleniumProject.PageObject
{
    /*
     * Clase para representar la pagina del inventario
     */
    public class InventoryPage
    {
        protected IWebDriver Driver;

        //Locators
        protected By Title = By.ClassName("title");

        public InventoryPage(IWebDriver driver)
        {
            Driver = driver;
            if(!Driver.Title.Equals("Swag Labs"))
            {
                throw new Exception("This is not the inventory page");
            }
        }

        public bool TitleIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Title);
        }


    }

}
