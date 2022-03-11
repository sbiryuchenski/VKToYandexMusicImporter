using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;

namespace VKToYandexMusicImporter
{
    class WebPage
    {
        IWebDriver driver;

        public WebPage()
        {
            InitBrowser();
        }
        private void InitBrowser()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Url = "https://vk.com/";
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Web browser
        /// </summary>
        /// <returns></returns>
        public IWebDriver Driver()
        {
            return driver;
        }

        /// <summary>
        /// Open url in a driver
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public WebPage GoToPage(string url)
        {
            driver.Url = url;
            return this;
        }

        /// <summary>
        /// Ckick on element
        /// </summary>
        /// <returns></returns>
        public WebPage ClickElement(string name)
        {
            // TODO: Замутить ожидания
            driver.FindElement(Element.GetElement(name)).Click();
            return this;
        }
    }
}
