using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoko.Models.Client;

public class CL_AniDB_Anime : ICloneable
{
    public int AniDB_AnimeID { get; set; }

    public int AnimeID { get; set; }

    public int EpisodeCount { get; set; }

    public DateTime? AirDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string URL { get; set; }

    public string Picname { get; set; }

    public int BeginYear { get; set; }

    public int EndYear { get; set; }

    public int AnimeType { get; set; }

    public string MainTitle { get; set; }

    public string AllTitles { get; set; }

    public string AllTags { get; set; }

    public string Description { get; set; }

    public int EpisodeCountNormal { get; set; }

    public int EpisodeCountSpecial { get; set; }

    public int Rating { get; set; }

    public int VoteCount { get; set; }

    public int TempRating { get; set; }

    public int TempVoteCount { get; set; }

    public int AvgReviewRating { get; set; }

    public int ReviewCount { get; set; }

    [Obsolete("Deprecated in favor of AniDB_AnimeUpdate. This is for when an AniDB_Anime fails to save")]
    public DateTime DateTimeUpdated { get; set; }

    public DateTime DateTimeDescUpdated { get; set; }

    public int ImageEnabled { get; set; }

    public int Restricted { get; set; }

    public int? ANNID { get; set; }

    public int? AllCinemaID { get; set; }

    public int? AnisonID { get; set; }

    public int? SyoboiID { get; set; }

    public string Site_JP { get; set; }

    public string Site_EN { get; set; }

    public string Wikipedia_ID { get; set; }

    public string WikipediaJP_ID { get; set; }

    public string CrunchyrollID { get; set; }

    public int? LatestEpisodeNumber { get; set; }

    public int DisableExternalLinksFlag { get; set; }

    public CL_AniDB_Anime_DefaultImage DefaultImagePoster { get; set; }

    public CL_AniDB_Anime_DefaultImage DefaultImageFanart { get; set; }

    public CL_AniDB_Anime_DefaultImage DefaultImageWideBanner { get; set; }

    public List<CL_AniDB_Character> Characters { get; set; }

    public List<CL_AniDB_Anime_DefaultImage> Fanarts { get; set; }

    public List<CL_AniDB_Anime_DefaultImage> Banners { get; set; }

    public string FormattedTitle { get; set; }

    public CL_AniDB_Anime() { }

    public object Clone() =>
        new CL_AniDB_Anime()
        {
            AniDB_AnimeID = AniDB_AnimeID,
            AnimeID = AnimeID,
            EpisodeCount = EpisodeCount,
            AirDate = AirDate,
            EndDate = EndDate,
            URL = URL,
            Picname = Picname,
            BeginYear = BeginYear,
            EndYear = EndYear,
            AnimeType = AnimeType,
            MainTitle = MainTitle,
            AllTitles = AllTitles,
            AllTags = AllTags,
            Description = Description,
            EpisodeCountNormal = EpisodeCountNormal,
            EpisodeCountSpecial = EpisodeCountSpecial,
            Rating = Rating,
            VoteCount = VoteCount,
            TempRating = TempRating,
            TempVoteCount = TempVoteCount,
            AvgReviewRating = AvgReviewRating,
            ReviewCount = ReviewCount,
#pragma warning disable 0618
            DateTimeUpdated = DateTimeUpdated,
#pragma warning restore 0618
            DateTimeDescUpdated = DateTimeDescUpdated,
            ImageEnabled = ImageEnabled,
            Restricted = Restricted,
            ANNID = ANNID,
            AllCinemaID = AllCinemaID,
            AnisonID = AnisonID,
            SyoboiID = SyoboiID,
            Site_JP = Site_JP,
            Site_EN = Site_EN,
            Wikipedia_ID = Wikipedia_ID,
            WikipediaJP_ID = WikipediaJP_ID,
            CrunchyrollID = CrunchyrollID,
            LatestEpisodeNumber = LatestEpisodeNumber,
            DefaultImagePoster = (CL_AniDB_Anime_DefaultImage)DefaultImagePoster?.Clone(),
            DefaultImageFanart = (CL_AniDB_Anime_DefaultImage)DefaultImageFanart?.Clone(),
            DefaultImageWideBanner = (CL_AniDB_Anime_DefaultImage)DefaultImageWideBanner?.Clone(),
            Characters = Characters?.Select(a => a.Clone()).Cast<CL_AniDB_Character>().ToList(),
            Fanarts = Fanarts?.Select(a => a.Clone()).Cast<CL_AniDB_Anime_DefaultImage>().ToList(),
            Banners = Banners?.Select(a => a.Clone()).Cast<CL_AniDB_Anime_DefaultImage>().ToList(),
            FormattedTitle = FormattedTitle
        };
}
