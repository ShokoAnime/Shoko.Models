using System;
using System.Collections.Generic;
using System.Text;

namespace Shoko.Models.WebCache
{
    public class WebCache_Ban
    {
        public int AniDBUserId { get; set; }
        public string Reason { get; set; }
        public int Hours { get; set; }
    }
}
