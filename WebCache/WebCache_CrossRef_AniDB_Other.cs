﻿using Shoko.Models.Client;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_Other : CL_CrossRef_AniDB_Other_Response
    {
        public long DateSubmitted { get; set; }
        public string Self { get; set; }
    }
}