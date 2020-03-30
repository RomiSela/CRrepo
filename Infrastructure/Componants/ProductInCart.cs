using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;

namespace Infrastructure
{
    public class ProductInCart : ComponantBase
    {
        private IWebElement TotalPrice => ParentElement.WaitAndFindElement(By.CssSelector(".cart_total .price"));
        private Quantity Quantity => new Quantity(Driver, ParentElement.WaitAndFindElement(By.CssSelector(".cart_quantity.text-center")));
        private IWebElement TrashButton => ParentElement.WaitAndFindElement(By.CssSelector(".icon-trash"));
        private IWebElement UnitPrice => ParentElement.WaitAndFindElement(By.CssSelector(".cart_unit .price span"));

        public ProductInCart(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

        public void PressTrashButton()
        {
            TrashButton.Click();
        }

        public void ClickOnAddQuantity()
        {
            Quantity.ClickOnAddQuantity();
        }

        public double GetUnitPrice()
        {
            string price = UnitPrice.Text;
            price =price.Substring(1);
            return double.Parse(price);
        }

        public double GetTotalPrice()
        {
            string price = TotalPrice.Text;
            price = price.Substring(1);
            return double.Parse(price);
        }

        
    }
}
