using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core;

namespace Infrastructure.Pages
{
    public class CartPage : BasePage
    {
        private List<ProductInCart> ProductInCarts => Driver.FindElements(By.CssSelector("tbody .cart_item"))
            .Select(element => new ProductInCart(Driver, element)).ToList();
        private IWebElement TotalProductsPrice => Driver.WaitAndFindElement(By.CssSelector("#total_product"));
        private IWebElement AlertNoProducts => Driver.WaitAndFindElement(By.CssSelector(".alert.alert-warning"));

        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetTotalProductsPrice() => TotalProductsPrice.Text;

        public CartPage PressTrashButton(int productIndex)
        {
            ProductInCarts[productIndex].PressTrashButton();
            return new CartPage(Driver);
        }

        public bool AllertNoProductPerform() => AlertNoProducts.Displayed;

        public int NumberOfProducts() => ProductInCarts.Count();

        public CartPage AddQuantityToProduct(int productIndex)
        {
            ProductInCarts[productIndex].ClickOnAddQuantity();
            return new CartPage(Driver);
        }

        public double GetUnitPrice(int productIndex) => ProductInCarts[productIndex].GetUnitPrice();

        public double GetTotalPrice(int productIndex) => ProductInCarts[productIndex].GetTotalPrice();
    }
}
