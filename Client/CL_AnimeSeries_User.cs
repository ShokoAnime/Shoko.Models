using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoko.Models.Client;

public class CL_AnimeSeries_User : ICloneable
{
    public int AnimeSeries_UserID { get; set; }

    public int JMMUserID { get; set; }

    public int AnimeSeriesID { get; set; }

    public int UnwatchedEpisodeCount { get; set; }

    public int HiddenUnwatchedEpisodeCount { get; set; }

    public int WatchedEpisodeCount { get; set; }

    public DateTime? WatchedDate { get; set; }

    public int PlayedCount { get; set; }

    public int WatchedCount { get; set; }

    public int StoppedCount { get; set; }

    public DateTime? LastEpisodeUpdate { get; set; }

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

    public List<CL_CrossRef_AniDB_TvDB> CrossRefAniDBTvDBV2 { get; set; }

    public CL_CrossRef_AniDB_Other CrossRefAniDBMovieDB { get; set; }

    public List<CL_CrossRef_AniDB_MAL> CrossRefAniDBMAL { get; set; }

    public List<CL_TvDB_Series> TvDB_Series { get; set; }

    public CL_MovieDB_Movie MovieDB_Movie { get; set; }

    public CL_AnimeSeries_User() { }

    public object Clone() =>
        new CL_AnimeSeries_User()
        {
            AnimeSeries_UserID = AnimeSeries_UserID,
            JMMUserID = JMMUserID,
            AnimeSeriesID = AnimeSeriesID,
            UnwatchedEpisodeCount = UnwatchedEpisodeCount,
            HiddenUnwatchedEpisodeCount = HiddenUnwatchedEpisodeCount,
            WatchedEpisodeCount = WatchedEpisodeCount,
            WatchedDate = WatchedDate,
            PlayedCount = PlayedCount,
            WatchedCount = WatchedCount,
            StoppedCount = StoppedCount,
            LastEpisodeUpdate = LastEpisodeUpdate,
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
            CrossRefAniDBTvDBV2 =
                CrossRefAniDBTvDBV2?.Select(a => a.Clone()).Cast<CL_CrossRef_AniDB_TvDB>().ToList(),
            CrossRefAniDBMovieDB = (CL_CrossRef_AniDB_Other)CrossRefAniDBMovieDB?.Clone(),
            CrossRefAniDBMAL = CrossRefAniDBMAL?.Select(a => a.Clone()).Cast<CL_CrossRef_AniDB_MAL>().ToList(),
            TvDB_Series = TvDB_Series?.Select(a => a.Clone()).Cast<CL_TvDB_Series>().ToList(),
            MovieDB_Movie = (CL_MovieDB_Movie)MovieDB_Movie?.Clone()
        };
}
