using System;
using System.Windows.Forms;

namespace VKToYandexMusicImporter
{
    public partial class MainWindow : Form
    {
        BigDealer actor;
        public MainWindow()
        {
            InitializeComponent();
            actor = new BigDealer();
        }
        private void launchBrowserButton_Click(object sender, EventArgs e)
        {
            if (actor.Authorize())
            {
                //page.ClickElement(ElementName.MusicBtn)
                //    .ClickElement(ElementName.ShowAllBtn);

                actor.ClickElement(ElementName.MyProfileBtn)
                    .ClickElement(ElementName.MyProfileMusicBtn);


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
