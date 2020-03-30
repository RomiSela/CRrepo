using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class LeftSideMenu : ComponantBase
    {
        private IList<IWebElement> Colors => ParentElement.FindElements(By.CssSelector("#ul_layered_id_attribute_group_3 .nomargin.hiddable.col-lg-6")).ToList();

        public LeftSideMenu(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }
    }
}
