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

        /// <summary>
        /// Get text from element
        /// </summary>
        /// <param name="elementName"></param>
        /// <param name="innerElement"></param>
        /// <returns></returns>
        public string GetTextFromElement(string elementName, string innerElement = null)
        {
            var elementWithText = driver.FindElement(Element.GetElement(elementName));
            if (innerElement != null)
                elementWithText = elementWithText.FindElement(Element.GetElement(innerElement));
            if (!string.IsNullOrEmpty(elementWithText.Text))
                return elementWithText.Text;
            else
                throw new System.Exception($"The fucking element {elementName} {innerElement} don't fucking contains a fucking text u bitch");
        }

        /// <summary>
        /// Get a number from element
        /// </summary>
        /// <param name="elementName"></param>
        /// <param name="innerElement"></param>
        /// <returns></returns>
        public int GetNumberGromElement(string elementName, string innerElement = null)
            =>
            int.Parse(GetTextFromElement(elementName, innerElement));

        /// <summary>
        /// Scroll to element
        /// </summary>
        /// <returns></returns>
        public WebPage ScrollToElement(string element)
        {
            driver.FindElement(Element.GetElement(element)).ScrollToElement(Driver());
            return this;
        }
    }
}