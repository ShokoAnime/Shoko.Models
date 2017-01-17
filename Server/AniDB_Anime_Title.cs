﻿

namespace Shoko.Models.Server
{
    public class AniDB_Anime_Title
    {
        #region Server DB columns
        public int AniDB_Anime_TitleID { get; private set; }
        public int AnimeID { get; set; }
        public string TitleType { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }

        #endregion

        public AniDB_Anime_Title() //Empty Constructor for nhibernate
        {

        }
    }
}