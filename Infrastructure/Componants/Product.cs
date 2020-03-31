using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Core;

namespace Infrastructure
{
    public class Product : ComponentBase
    {
        private IWebElement AddToCartButton =>  ParentElement.WaitAndFindElement(By.CssSelector(".button.ajax_add_to_cart_button.btn.btn-default span"));
        private IWebElement Picture => ParentElement.WaitAndFindElement(By.CssSelector(".left-block"));
        private IList<IWebElement> productColors => ParentElement.FindElements(By.CssSelector(".color_to_pick_list.clearfix a"));

        public Product(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void StandOnProduct()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(ParentElement.WaitAndFindElement(By.CssSelector(".left-block"))).Perform();
        }

        public void AddToCart() => AddToCartButton.Click();

        public bool AddToCartPerform() => (AddToCartButton.Displayed && AddToCartButton.Enabled);

        public void ClickColor(int colorIndex) => productColors[colorIndex].Click();
    }
}
