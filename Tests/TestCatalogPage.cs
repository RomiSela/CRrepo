using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;
using Core;
using FluentAssertions;

namespace Tests
{
    [TestClass]
    public class TestCatalogPage : TestBase
    {
        [TestMethod]
        public void PointMouseAtProductShowsAddToCart()
        {
            HomePage
               .MoveToWomenCatalog()
               .PointMouseAtProduct(indexNumberZero)
               .AddToCartButtonPerform(indexNumberZero).Should().BeTrue();
        }

        [TestMethod]
        public void UnPointMouseAtProductShowsAddToCart()
        {
            HomePage
               .MoveToWomenCatalog()
               .AddToCartButtonPerform(indexNumberZero).Should().BeFalse();
        }

        [TestMethod]
        public void AddAProductToCart()
        {
            HomePage
                .MoveToWomenCatalog()
                .AddProductAndProceedToCart(indexNumberZero)
                .NumberOfProducts().Should().Be(1);
        }

        [TestMethod]
        public void ChooseColorOpenProductPageWithSelectedColor()
        {
            string color = 
            HomePage
                .MoveToWomenCatalog()
                .ChooseColor(indexNumberZero, indexNumberZero)
                .GetSelectedColor();
            //not done
        }
    }
}
