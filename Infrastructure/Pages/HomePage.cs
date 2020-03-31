using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure.Pages
{
    public class HomePage : BasePage
    {
        private LeftSideMenu LeftSideMenu => new LeftSideMenu(Driver, Driver.FindElement(By.CssSelector("#layered_form")));

        public HomePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
