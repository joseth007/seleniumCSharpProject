using OpenQA.Selenium;
using System;

namespace SeleniumProject.PageObject
{
    /*
     * Clase para representar la pagina del Login
     */
    public class LoginPage
    {
        //Selenium Driver
        protected IWebDriver Driver;

        //Locators
        protected By UserInput = By.Id("user-name");
        protected By PassInput = By.Id("password");
        protected By LoginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Swag Labs"))
            {
                throw new Exception("This is not the login page");
            }
        }

        //Metodo para ingresar el usuario
        public void TypeUserName(String user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }
        //Metodo para ingresar el password
        public void TypePassword(String pass)
        {
            Driver.FindElement(PassInput).SendKeys(pass);
        }

        //Metodo para clicar el login button
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        public InventoryPage LoginAs(string user, string password)
        {
            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new InventoryPage(Driver);
        }

    }
}
