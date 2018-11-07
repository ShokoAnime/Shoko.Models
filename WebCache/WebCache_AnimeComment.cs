﻿namespace Shoko.Models.WebCache
{
    public class WebCache_AnimeComment
    {
        // In Summary
        public string Source { get; set; } // trakt, anidb
        public int CommentType { get; set; } // trakt - Comment, anidb (for fans, must see, Recommended)
        public string CommentText { get; set; }
        public bool IsSpoiler { get; set; }
        public long CommentDateLong { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string ImageURL { get; set; }

        // In Detail
    }
}