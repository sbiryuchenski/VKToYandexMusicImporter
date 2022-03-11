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
        WebPage page;

        public MainWindow()
        {
            InitializeComponent();
            page = new WebPage();
        }
        private void launchBrowserButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Авторизуйтесь в ВК и нажмите ОК");
            if (result == DialogResult.OK)
            {
                //page.ClickElement(ElementName.Name);
                //driver.FindElement(findFriendMusic).SendKeys("Olga Biryuchinskaya");

                //var musicCount = driver.FindElement(countMusic).Text;
                //int numberMusic;
                //int.TryParse(string.Join("", musicCount.Where(c => char.IsDigit(c))), out numberMusic);

                //driver.FindElement(foundFriend).Click();
                //if(driver.FindElements(song).Count() != numberMusic)
                //{
                //    driver.FindElements(song).Last().SendKeys(OpenQA.Selenium.Keys.PageDown);
                //}
            }
        }
    }
}
