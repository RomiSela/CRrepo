using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;

namespace Infrastructure
{
    public class OptionsAfterAddingProduct : ComponantBase
    {
        private IWebElement ContinueShoppingButton => Driver.WaitAndFindElement(By.CssSelector(".continue.btn.btn-default.button.exclusive-medium"));
        private IWebElement ProceedToCheckoutButton => Driver.WaitAndFindElement(By.CssSelector("#layer_cart .btn.btn-default.button-medium"));

        public OptionsAfterAddingProduct(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void ClickContinueShoppingButton()
        {
            ContinueShoppingButton.Click();
        }

        public void ClickProceedToCheckoutButton()
        {
            ProceedToCheckoutButton.Click();
        }
    }
}
