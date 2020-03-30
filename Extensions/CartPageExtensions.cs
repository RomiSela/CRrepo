using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Pages;

namespace Extensions
{
    public static class CartPageExtensions
    {
        public static double[] UnitTotalPrice(this CartPage cartPage, int place)
        {
            double[] unitTotalPrice = new double[2];
            unitTotalPrice[0] = cartPage.GetUnitPrice(place);
            unitTotalPrice[1] = cartPage.GetTotalPrice(place);
            return unitTotalPrice;
        }
    }
}
