using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductPage : BasePage
    {
        private IWebElement SelectedColor => Driver.WaitAndFindElement(By.CssSelector(".selected a"));

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }
        
        public string GetSelectedColor()
        {
            return SelectedColor.Text;
        }
    }
}
