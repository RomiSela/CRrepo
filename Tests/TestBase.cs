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
        public int indexNumberZero { get; private set; }
        public int indexNumberOne { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl($@"{ConfigManager.WebsiteUrl}");
            Driver.Manage().Window.Maximize();
            HomePage = new HomePage(Driver);
            indexNumberOne = 1;
            indexNumberZero = 0;
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}