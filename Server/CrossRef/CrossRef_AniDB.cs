using Shoko.Models.Enums;

namespace Shoko.Models.Server
{
    public class CrossRef_AniDB
    {
        public int CrossRef_AniDBID { get; set; }
        public int AniDBID { get; set; }
        public string Provider { get; set; }
        public string ProviderID { get; set; }
        public CrossRefSource CrossRefSource { get; set; }
        public MediaType ProviderMediaType { get; set; }
    }
}
