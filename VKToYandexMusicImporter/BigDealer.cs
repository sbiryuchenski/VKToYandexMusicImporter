using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKToYandexMusicImporter
{
    /// <summary>
    /// Makes a deal 😎
    /// </summary>
    class BigDealer : WebPage
    {
        int songsNumber;
        public BigDealer()
        {
        }

        /// <summary>
        /// Fucking authorize
        /// </summary>
        /// <returns></returns>
        public bool Authorize()
        {
            var result = MessageBox.Show("Авторизуйтесь в ВК и нажмите ОК");
            return result == DialogResult.OK ? true : false;
        }

        /// <summary>
        /// Go to my profile and get number of Songs
        /// </summary>
        /// <returns></returns>
        public BigDealer GetNumberOfSongs()
        {
            ClickElement(ElementName.MyProfileBtn);
            ScrollToElement(ElementName.MyProfileMusicBtn);
            songsNumber = GetNumberGromElement(ElementName.MyProfileMusicBtn, ElementName.SongsNumber);
            return this;
        }
        public BigDealer GoToMusicPage()
        {
            return this;
        }
    }
}