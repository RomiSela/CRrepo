using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Extensions;
using Core;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestCartPage : TestBase
    {
        [TestMethod]
        public void AddingOneDeletingProductFromCart()
        {
            HomePage.
                MoveToWomenCatalog()
                .AddProductAndProceedToCart(ConfigManager.IndexOfProductZero)
                .PressTrashButton(ConfigManager.IndexOfProductZero)
                .AllertPerform().Should().BeTrue();
        }

        [TestMethod]
        public void AddingSomeDeletingProductFromCart()
        {
            HomePage
                .MoveToWomenCatalog()
                .AddTwoProductsAndProceedToCart()
                .PressTrashButton(ConfigManager.IndexOfProductZero)
                .NumberOfProducts().Should().Be(1);
        }

        [TestMethod]
        public void AddingQuantityToProductInCart()
        { 
            double[] UnitTotalPrice =
            HomePage.
               MoveToWomenCatalog()
               .AddProductAndProceedToCart(ConfigManager.IndexOfProductZero)
               .AddQuantityToProduct(ConfigManager.IndexOfProductZero)
               .UnitTotalPrice(ConfigManager.IndexOfProductZero);
            UnitTotalPrice[1].Should().Be(UnitTotalPrice[0] * 2);
        }
    }
}
