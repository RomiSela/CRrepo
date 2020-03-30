using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    public abstract class ComponantBase : DriverUser
    {
        protected IWebElement ParentElement { get; private set; }

        public ComponantBase(IWebDriver driver, IWebElement element) : base(driver)
        {
            ParentElement = element;
        }
    }
}
