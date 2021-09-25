using Shoko.Models.Enums;

namespace Shoko.Models.Server
{
    public class CrossRef_AniDB_Episode
    {
        public int CrossRef_AniDB_EpisodeID { get; set; }
        public int AniDBEpisodeID { get; set; }
        public string Provider { get; set; }
        public string ProviderEpisodeID { get; set; }
        public MatchRating MatchRating { get; set; }
    }


}
