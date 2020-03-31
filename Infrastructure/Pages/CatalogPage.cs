using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Infrastructure.Pages;
using Core;

namespace Infrastructure
{
    public class CatalogPage : BasePage
    {
        private List<Product> Products => Driver.FindElements(By.CssSelector(".product_list.grid.row .product-container"))
            .Select(element => new Product(Driver, element)).ToList();
        private OptionsAfterAddingProduct OptionsAfterAddingProduct => 
            new OptionsAfterAddingProduct(Driver, Driver.FindElements(By.CssSelector(".button-container")).First());

        public CatalogPage(IWebDriver driver) : base(driver)
        {
        }

        public CatalogPage PointMouseAtProduct(int productIndex)
        {
            Products[productIndex].StandOnProduct();
            return new CatalogPage(Driver);
        }

        public CatalogPage AddToCart(int productIndex)
        {
            Products[productIndex].AddToCart();
            return new CatalogPage(Driver);
        }

        public CatalogPage PressContinueShopping()
        {
            OptionsAfterAddingProduct.ClickContinueShoppingButton();
            return new CatalogPage(Driver);
        }

        public CartPage PressProceedToCheckout()
        {
            OptionsAfterAddingProduct.ClickProceedToCheckoutButton();
            return new CartPage(Driver);
        }

        public bool AddToCartButtonPerform(int productIndex) => Products[productIndex].AddToCartPerform();

        public ProductPage ChooseColor(int productIndex, int colorIndex)
        {
            Products[productIndex].ClickColor(colorIndex);
            return new ProductPage(Driver);
        }
    }
}
