using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;
namespace Infrastructure
{
    public class TopMenu : ComponantBase
    {
        private IWebElement WomenButton => ParentElement.FindElements(By.CssSelector("li a")).First();

        public TopMenu(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void ClickOnWomen()
        {
            WomenButton.Click();
        }
    }
}
