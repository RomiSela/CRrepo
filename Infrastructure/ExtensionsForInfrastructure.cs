using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Core;

namespace Infrastructure
{
    public static class ExtensionsForInfrastructure
    {
        public static IWebElement WaitAndFindElement(this ISearchContext context, By by)
        {
            var wait = new DefaultWait<ISearchContext>(context);
            wait.Timeout = TimeSpan.FromSeconds(ConfigManager.NumberOfSecondsToWait);
            return wait.Until(ctx => {
                var elem = ctx.FindElement(by);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
                if (!elem.Enabled || !elem.Displayed)
                {
                    return null;
                }

                return elem;
            });
        }
    }
}
