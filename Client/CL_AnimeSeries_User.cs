using System;
using System.Collections.Generic;
using System.Linq;
using Shoko.Models.Server;

namespace Shoko.Models.Client
{
    public class CL_AnimeSeries_User : AnimeSeries_User, ICloneable
    {
        public int AnimeGroupID { get; set; }
        public int AniDB_ID { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string DefaultAudioLanguage { get; set; }
        public string DefaultSubtitleLanguage { get; set; }
        public DateTime? EpisodeAddedDate { get; set; }
        public DateTime? LatestEpisodeAirDate { get; set; }
        public int LatestLocalEpisodeNumber { get; set; }
        public string SeriesNameOverride { get; set; }

        public string DefaultFolder { get; set; }

        public int MissingEpisodeCount { get; set; }
        public int MissingEpisodeCountGroups { get; set; }
        public DayOfWeek? AirsOn { get; set; }

        public CL_AniDB_AnimeDetailed AniDBAnime { get; set; }
        public List<CrossRef_AniDB> CrossRefAniDB { get; set; }
        public List<TvDB_Series> TvDB_Series { get; set; }
        public MovieDB_Movie MovieDB_Movie { get; set; }
        public List<CrossRef_AniDB_EpisodeMap> EpisodeMap { get; set; }

        public CL_AnimeSeries_User()
        {
        }

        public CL_AnimeSeries_User(AnimeSeries_User obj)
        {
            AnimeSeries_UserID = obj.AnimeSeries_UserID;
            JMMUserID = obj.JMMUserID;
            AnimeSeriesID = obj.AnimeSeriesID;
            UnwatchedEpisodeCount = obj.UnwatchedEpisodeCount;
            WatchedEpisodeCount = obj.WatchedEpisodeCount;
            WatchedDate = obj.WatchedDate;
            PlayedCount = obj.PlayedCount;
            WatchedCount = obj.WatchedCount;
            StoppedCount = obj.StoppedCount;
        }

        public new object Clone()
        {
            var seriesBase = new CL_AnimeSeries_User(this)
            {
                AnimeGroupID = AnimeGroupID,
                AniDB_ID = AniDB_ID,
                DateTimeUpdated = DateTimeUpdated,
                DateTimeCreated = DateTimeCreated,
                DefaultAudioLanguage = DefaultAudioLanguage,
                DefaultSubtitleLanguage = DefaultSubtitleLanguage,
                EpisodeAddedDate = EpisodeAddedDate,
                LatestEpisodeAirDate = LatestEpisodeAirDate,
                LatestLocalEpisodeNumber = LatestLocalEpisodeNumber,
                SeriesNameOverride = SeriesNameOverride,
                DefaultFolder = DefaultFolder,
                MissingEpisodeCount = MissingEpisodeCount,
                MissingEpisodeCountGroups = MissingEpisodeCountGroups,
                AirsOn = AirsOn,
                AniDBAnime = AniDBAnime,
                CrossRefAniDB = CrossRefAniDB.Select(a=>new CrossRef_AniDB
                {
                    Provider = a.Provider,
                    AniDBID = a.AniDBID,
                    CrossRefSource = a.CrossRefSource,
                    CrossRef_AniDBID = a.CrossRef_AniDBID,
                    ProviderID = a.ProviderID,
                    ProviderMediaType = a.ProviderMediaType
                }).ToList(),
                TvDB_Series = TvDB_Series?.Select(a => a.Clone()).Cast<TvDB_Series>().ToList(),
                MovieDB_Movie = (MovieDB_Movie) MovieDB_Movie?.Clone()
            };

            return seriesBase;
        }
    }
}
