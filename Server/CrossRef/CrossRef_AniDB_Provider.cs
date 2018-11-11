using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Enums;

namespace Shoko.Models.Server.CrossRef
{
    public class CrossRef_AniDB_Provider
    {
        public int CrossRef_AniDB_ProviderID { get; set; }
        public int AnimeID { get; set; }
        public string CrossRefID { get; set; }
        public CrossRefSource CrossRefSource { get; set; }
        public CrossRefType CrossRefType { get; set; }
        public string EpisodesData { get; set; }
        public string EpisodesOverrideData { get; set; }
    }
}
