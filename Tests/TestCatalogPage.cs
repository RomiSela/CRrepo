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
               .PointMouseAtPicture(ConfigManager.IndexOfProductZero)
               .AddToCartButtonPerform(ConfigManager.IndexOfProductZero).Should().BeTrue();
        }

        [TestMethod]
        public void UnPointMouseAtProductShowsAddToCart()
        {
            HomePage
               .MoveToWomenCatalog()
               .AddToCartButtonPerform(ConfigManager.IndexOfProductZero).Should().BeFalse();
        }

        [TestMethod]
        public void AddAProductToCart()
        {
            HomePage
                .MoveToWomenCatalog()
                .AddProductAndProceedToCart(ConfigManager.IndexOfProductZero)
                .NumberOfProducts().Should().Be(1);
        }

        [TestMethod]
        public void ChooseColorOpenProductPageWithSelectedColor()
        {
            string color = 
            HomePage
                .MoveToWomenCatalog()
                .ChooseColor(ConfigManager.IndexOfProductZero, ConfigManager.IndexOfProductZero)
                .GetSelectedColor();
        }
    }
}
