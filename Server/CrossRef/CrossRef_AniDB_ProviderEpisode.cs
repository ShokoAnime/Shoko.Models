using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Enums;

namespace Shoko.Models.Server.CrossRef
{
    public class CrossRef_AniDB_ProviderEpisode
    {
        public int AniDBEpisodeID { get; set; }
        public string ProviderEpisodeID { get; set; }
        public MatchRating MatchRating { get; set; }
    }
}
