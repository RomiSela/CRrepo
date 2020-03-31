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
                .AddProductAndProceedToCart(indexNumberZero)
                .PressTrashButton(indexNumberZero)
                .AllertNoProductPerform().Should().BeTrue();
        }

        [TestMethod]
        public void AddingSomeDeletingProductFromCart()
        {
            HomePage
                .MoveToWomenCatalog()
                .AddTwoProductsAndProceedToCart(indexNumberZero,indexNumberOne)
                .PressTrashButton(indexNumberZero)
                .NumberOfProducts().Should().Be(1);
        }

        [TestMethod]
        public void AddingQuantityToProductInCart()
        { 
            double[] UnitTotalPrice =
            HomePage.
               MoveToWomenCatalog()
               .AddProductAndProceedToCart(indexNumberZero)
               .AddQuantityToProduct(indexNumberZero)
               .UnitTotalPrice(indexNumberZero);
            UnitTotalPrice[indexNumberOne].Should().Be(UnitTotalPrice[indexNumberZero] * 2);
        }
    }
}
