using System;

namespace Shoko.Models.Client;

public class CL_AniDB_Anime_DefaultImage : ICloneable
{
    public int AniDB_Anime_DefaultImageID { get; set; }

    public int AnimeID { get; set; }

    public int ImageParentID { get; set; }

    public int ImageParentType { get; set; }

    public int ImageType { get; set; }

    public CL_MovieDB_Poster MoviePoster { get; set; }

    public CL_MovieDB_Fanart MovieFanart { get; set; }

    public CL_TvDB_ImagePoster TVPoster { get; set; }

    public CL_TvDB_ImageFanart TVFanart { get; set; }

    public CL_TvDB_ImageWideBanner TVWideBanner { get; set; }

    public CL_AniDB_Anime_DefaultImage() { }

    public object Clone() =>
        new CL_AniDB_Anime_DefaultImage()
        {
            AniDB_Anime_DefaultImageID = AniDB_Anime_DefaultImageID,
            AnimeID = AnimeID,
            ImageParentID = ImageParentID,
            ImageParentType = ImageParentType,
            ImageType = ImageType,
            MoviePoster = (CL_MovieDB_Poster)MoviePoster?.Clone(),
            MovieFanart = (CL_MovieDB_Fanart)MovieFanart?.Clone(),
            TVPoster = (CL_TvDB_ImagePoster)TVPoster?.Clone(),
            TVFanart = (CL_TvDB_ImageFanart)TVFanart?.Clone(),
            TVWideBanner = (CL_TvDB_ImageWideBanner)TVWideBanner?.Clone()
        };
}
