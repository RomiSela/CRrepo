using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Infrastructure;
using Infrastructure.Pages;
using Core;

namespace Extensions
{
    public static class CatalogPageExtensions
    {
        public static CartPage AddProductAndProceedToCart(this CatalogPage catalogPage, int place)
        {
            return catalogPage
                .AddProductToCart(place)
                .PressProceedToCheckout();
        }
        private static CatalogPage AddProductToCart(this CatalogPage catalogPage, int place)
        {
            return catalogPage
                .PointMouseAtPicture(place)
                .AddToCart(place);
        }

        public static CartPage AddTwoProductsAndProceedToCart(this CatalogPage catalogPage)
        {
            return catalogPage
            .PointMouseAtPicture(ConfigManager.IndexOfProductZero)
            .AddToCart(ConfigManager.IndexOfProductZero)
            .PressContinueShopping()
            .AddProductAndProceedToCart(ConfigManager.IndexOfProductOne);
        }

        public static CatalogPage AddProductAndContinueShopping(this CatalogPage catalogPage, int place)
        {
            return catalogPage
                .AddProductToCart(place)
                .PressContinueShopping();
        }
    }
}
