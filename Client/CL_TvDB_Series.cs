
using System;

namespace Shoko.Models.Client;

public class CL_TvDB_Series : ICloneable
{
    public int TvDB_SeriesID { get; set; }

    public int SeriesID { get; set; }

    public string Overview { get; set; }

    public string SeriesName { get; set; }

    public string Status { get; set; }

    public string Banner { get; set; }

    public string Fanart { get; set; }

    public string Lastupdated { get; set; }

    public string Poster { get; set; }

    /// <remarks>
    /// Saved at 10x to preserve decimal. resulting in 82/100
    /// </remarks>
    public int? Rating { get; set; }

    public object Clone() =>
        new CL_TvDB_Series
        {
            TvDB_SeriesID = TvDB_SeriesID,
            SeriesID = SeriesID,
            Overview = Overview,
            SeriesName = SeriesName,
            Status = Status,
            Banner = Banner,
            Fanart = Fanart,
            Lastupdated = Lastupdated,
            Poster = Poster,
            Rating = Rating
        };
}
