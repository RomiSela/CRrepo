using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Quantity : ComponantBase
    {
        private IWebElement QuantityNumber => ParentElement.WaitAndFindElement(By.ClassName("cart_quantity_input form-control grey"));
        private IWebElement AddQuantity => ParentElement.WaitAndFindElement(By.ClassName("icon-plus"));
        private IWebElement MinusQuantity => ParentElement.WaitAndFindElement(By.ClassName("icon-minus"));

        public Quantity(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void ClickOnAddQuantity()
        {
            AddQuantity.Click();
        }
    }
}
