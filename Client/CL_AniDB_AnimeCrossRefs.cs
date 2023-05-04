using System.Collections.Generic;

namespace Shoko.Models.Client;

public class CL_AniDB_AnimeCrossRefs
{
    public int AnimeID { get; set; }

    #region TvDB

    public List<CL_CrossRef_AniDB_TvDB> CrossRef_AniDB_TvDB { get; set; }

    public List<CL_TvDB_Series> TvDBSeries { get; set; }

    public List<CL_TvDB_Episode> TvDBEpisodes { get; set; }

    public List<CL_TvDB_ImageFanart> TvDBImageFanarts { get; set; }

    public List<CL_TvDB_ImagePoster> TvDBImagePosters { get; set; }

    public List<CL_TvDB_ImageWideBanner> TvDBImageWideBanners { get; set; }

    #endregion

    #region Trakt

    public List<CL_CrossRef_AniDB_Trakt> CrossRef_AniDB_Trakt { get; set; }

    public List<CL_Trakt_Show> TraktShows { get; set; }

    #endregion

    #region TMDB

    public CL_CrossRef_AniDB_Other CrossRef_AniDB_MovieDB { get; set; }

    public CL_MovieDB_Movie MovieDBMovie { get; set; }

    public List<CL_MovieDB_Fanart> MovieDBFanarts { get; set; }

    public List<CL_MovieDB_Poster> MovieDBPosters { get; set; }

    #endregion

    #region MAL

    public List<CL_CrossRef_AniDB_MAL> CrossRef_AniDB_MAL { get; set; }

    #endregion
}
