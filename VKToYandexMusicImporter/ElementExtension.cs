using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKToYandexMusicImporter
{
    public static class ElementExtension
    {
        /// <summary>
        /// Scroll to element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        public static void ScrollToElement(this IWebElement element, IWebDriver driver)
        {
            Actions act = new Actions(driver);
            act.MoveToElement(element)
                .Build()
                .Perform();
        }
    }
}
