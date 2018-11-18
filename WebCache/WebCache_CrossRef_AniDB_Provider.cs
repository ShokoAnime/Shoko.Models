using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Enums;
using Shoko.Models.Server.CrossRef;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_Provider : CrossRef_AniDB_Provider
    {
        public int AniDBUserId { get; set; }
        public WebCache_ReliabilityType Type { get; set; }
        public int PopularityCount { get; set; }
    }
}
