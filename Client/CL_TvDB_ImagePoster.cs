
using System;
using Shoko.Models.Interfaces;

namespace Shoko.Models.Client;

public class CL_TvDB_ImagePoster : IImageEntity, ICloneable
{
    public int TvDB_ImagePosterID { get;set; }

    public int Id { get; set; }

    public int SeriesID { get; set; }

    public string BannerPath { get; set; }

    public string BannerType { get; set; }

    public string BannerType2 { get; set; }

    public string Language { get; set; }

    public int Enabled { get; set; }

    public int? SeasonNumber { get; set; }

    public object Clone() =>
        new CL_TvDB_ImagePoster
        {
            TvDB_ImagePosterID = TvDB_ImagePosterID,
            Id = Id,
            SeriesID = SeriesID,
            BannerPath = BannerPath,
            BannerType = BannerType,
            BannerType2 = BannerType2,
            Language = Language,
            Enabled = Enabled,
            SeasonNumber = SeasonNumber
        };
}
