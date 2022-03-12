using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VKToYandexMusicImporter
{
    /// <summary>
    /// Elements getter
    /// </summary>
    static class Element
    {
        private static List<UiMapper> elements = new List<UiMapper>
        {
            new UiMapper{element = ElementName.Name, locator = By.XPath("//li[@id='l_aud']/a")},
            new UiMapper{element = ElementName.FindFriendMusic, locator = By.XPath("//input[@class='ui_search_field _field'][not(contains(@id, 'audio'))]")},
            new UiMapper{element = ElementName.FoundFriends, locator = By.XPath("//a[@class='audio_friend_name fl_l']")},
            new UiMapper{element = ElementName.CountMusic, locator = By.XPath("//div[@class='audio_friend_audios_count fl_l']")},
            new UiMapper{element = ElementName.Song, locator = By.CssSelector("a.audio_row__title_inner _audio_row__title_inner")},
            new UiMapper{element = ElementName.MusicBtn, locator = By.XPath("//a[contains(@href, 'audio')]")},
            new UiMapper{element = ElementName.ShowAllBtn, locator = By.XPath("//div[contains(@class, 'my_audios_block_header')]//a")},
            new UiMapper{element = ElementName.MyProfileBtn, locator = By.Id("l_pr")},
            new UiMapper{element = ElementName.MyProfileMusicBtn, locator = By.XPath("//a[contains(@href, 'audio')]//div[@class='header_top clear_fix']")},
            new UiMapper{element = ElementName.SongsNumber, locator = By.XPath(".//span[@class='header_count fl_l']")}
        };

        /// <summary>
        /// Get the locator by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static By GetElement(string name)
        {
            By locator = elements.Where(_ => _.element == name).Select(_ => _.locator).FirstOrDefault();
            if (locator == null)
                throw new Exception("Omg there's no such an element u stupid");
            return locator;
        }
    }
}