using System;

namespace Shoko.Models.Client;

public class CL_CrossRef_AniDB_MAL : ICloneable
{
    public int CrossRef_AniDB_MALID { get; set; }

    public int AnimeID { get; set; }

    public int MALID { get; set; }

    public string MALTitle { get; set; }

    public int StartEpisodeType { get; set; }

    public int StartEpisodeNumber { get; set; }

    public int CrossRefSource { get; set; }

    public object Clone() =>
        new CL_CrossRef_AniDB_MAL
        {
            CrossRef_AniDB_MALID = CrossRef_AniDB_MALID,
            AnimeID = AnimeID,
            MALID = MALID,
            MALTitle = MALTitle,
            StartEpisodeType = StartEpisodeType,
            StartEpisodeNumber = StartEpisodeNumber,
            CrossRefSource = CrossRefSource
        };
}
