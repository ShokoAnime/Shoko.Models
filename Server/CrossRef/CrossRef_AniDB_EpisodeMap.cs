using System;
using Shoko.Models.Enums;

namespace Shoko.Models.Server
{
    //Not A DB Entity
    public class CrossRef_AniDB_EpisodeMap : ICloneable
    {
        public string Provider { get; set; }
        public int AnimeID { get; set; }
        public string ProviderID { get; set; }

        public int AniDBEpisodeID { get; set; }
        public int AniDBStartEpisodeType { get; set; }
        public int AniDBStartEpisodeNumber { get; set; }

        public string ProviderEpisodeID { get; set; }
        public int ProviderSeasonNumber { get; set; }
        public int ProviderEpisodeNumber { get; set; }
        public string Title { get; set; }
        public CrossRefSource CrossRefSource { get; set; }
        public bool IsAdditive { get; set; }

        public object Clone()
        {
            return new CrossRef_AniDB_EpisodeMap
            {
                Provider = Provider,
                AnimeID = AnimeID,
                AniDBEpisodeID = AniDBEpisodeID,
                ProviderEpisodeID = ProviderEpisodeID,
                AniDBStartEpisodeType = AniDBStartEpisodeType,
                AniDBStartEpisodeNumber = AniDBStartEpisodeNumber,
                ProviderSeasonNumber = ProviderSeasonNumber,
                ProviderEpisodeNumber = ProviderEpisodeNumber,
                Title = Title,
                CrossRefSource = CrossRefSource,
                IsAdditive = IsAdditive
            };
        }
    }
}
