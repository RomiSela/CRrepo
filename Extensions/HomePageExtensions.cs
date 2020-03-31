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
        public static CartPage AddProductAndProceedToCart(this CatalogPage catalogPage, int productIndex)
        {
            return catalogPage
                .AddProductToCart(productIndex)
                .PressProceedToCheckout();
        }
        private static CatalogPage AddProductToCart(this CatalogPage catalogPage, int productIndex)
        {
            return catalogPage
                .PointMouseAtProduct(productIndex)
                .AddToCart(productIndex);
        }

        public static CartPage AddTwoProductsAndProceedToCart(this CatalogPage catalogPage, int indexZero, int indexOne)
        {
            return catalogPage
            .PointMouseAtProduct(indexZero)
            .AddToCart(indexZero)
            .PressContinueShopping()
            .AddProductAndProceedToCart(indexOne);
        }

        public static CatalogPage AddProductAndContinueShopping(this CatalogPage catalogPage, int productIndex)
        {
            return catalogPage
                .AddProductToCart(productIndex)
                .PressContinueShopping();
        }
    }
}
