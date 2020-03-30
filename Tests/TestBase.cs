using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Core;

namespace Tests
{
    [TestClass]
    public class TestBase
    {
        public HomePage HomePage { get; private set; }
        private IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl($@"{ConfigManager.WebsiteUrl}");
            Driver.Manage().Window.Maximize();
            HomePage = new HomePage(Driver);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}