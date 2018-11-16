using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Server.CrossRef;

namespace Shoko.Models.Client
{
    public class CL_CrossRef_AniDB_Provider : CrossRef_AniDB_Provider
    {
        public virtual List<CrossRef_AniDB_ProviderEpisode> Episodes { get; set; }
        public virtual List<CrossRef_AniDB_ProviderEpisode> EpisodesOverride { get; set; }

        public bool IsAdditive { get; set; }

    }
}
