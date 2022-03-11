using OpenQA.Selenium;

namespace VKToYandexMusicImporter
{
    /// <summary>
    /// Model for equal locators and names
    /// </summary>
    public class UiMapper
    {
        public string element { get; set; }
        public By locator { get; set; }
    }
}