namespace Shoko.Models.Server
{
    public class CrossRef_AniDB_Episode_Override
    {
        public int CrossRef_AniDB_OverrideID { get; set; }
        public int AniDBEpisodeID { get; set; }
        public string Provider { get; set; }
        public string ProviderEpisodeID { get; set; }

    }
}
