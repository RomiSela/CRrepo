using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Configuration;

namespace Core
{
    public static class ConfigManager
    {
        public static string WebsiteUrl => ConfigurationManager.AppSettings["WEBSITE_URL"];
        public static int NumberOfSecondsToWait => int.Parse(ConfigurationManager.AppSettings["NUMBER_OF_SECONDS_TO_WAIT"]);
    }
}
