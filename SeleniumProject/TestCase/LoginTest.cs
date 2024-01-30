using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;

namespace SeleniumProject.TestCase
{
    /*
     * Clase que contiene los casos de pruebas del Login
     */
    [TestFixture] // Anotacion de NUnit para marcar una clase que contenga casos de prueba
    public class LoginTest
    {
        //Selenium Driver
        protected IWebDriver Driver;

        [SetUp]//Anotacion de NUnit pra ejecutar un metodo antes de cada test
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }
        
        [Test]//Anoracion para marcar a un metodo como un caso de prueba automatizaco
        public void SuccessfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            InventoryPage inventoryPage = loginPage.LoginAs("standard_user", "secret_sauce");

            Assert.That(inventoryPage.TitleIsPresent());


        }

        [TearDown]// Anotacion para ejecutar un metodo despues de cada test
        public void AfterTest()
        {
            if(Driver != null)
            {
                Driver.Quit();
            }
        }

    }
}
