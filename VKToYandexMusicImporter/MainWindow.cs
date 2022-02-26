using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace VKToYandexMusicImporter
{
    public partial class MainWindow : Form
    {
        IWebDriver driver;
        By music;
        By findFriendMusic;
        By foundFriend;
        By countMusic;
        By song;

        public MainWindow()
        {
            music = By.XPath("//li[@id='l_aud']/a");
            findFriendMusic = By.XPath("//input[@class='ui_search_field _field'][not(contains(@id, 'audio'))]");
            foundFriend = By.XPath("//a[@class='audio_friend_name fl_l']");
            countMusic = By.XPath("//div[@class='audio_friend_audios_count fl_l']");
            song = By.CssSelector("a.audio_row__title_inner _audio_row__title_inner");

            InitializeComponent();
        }
        private void InitBrowser()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Url = "https://vk.com/";
            driver.SwitchTo().Window(driver.CurrentWindowHandle);
            driver.Manage().Window.Maximize();
        }

        private void launchBrowserButton_Click(object sender, EventArgs e)
        {
            InitBrowser();
            var result = MessageBox.Show("Авторизуйтесь в ВК и нажмите ОК");
            if (result == DialogResult.OK)
            {
                driver.FindElement(music).Click();
                driver.FindElement(findFriendMusic).SendKeys("Olga Biryuchinskaya");

                var musicCount = driver.FindElement(countMusic).Text;
                int numberMusic;
                int.TryParse(string.Join("", musicCount.Where(c => char.IsDigit(c))), out numberMusic);

                driver.FindElement(foundFriend).Click();
                if(driver.FindElements(song).Count() != numberMusic)
                {
                    driver.FindElements(song).Last().SendKeys(OpenQA.Selenium.Keys.PageDown);
                }
            }
        }
    }
}
