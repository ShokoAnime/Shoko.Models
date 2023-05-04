using System;

namespace Shoko.Models.Client;

public class CL_CrossRef_AniDB_Other : ICloneable
{
    public int CrossRef_AniDB_OtherID { get; set; }

    public int AnimeID { get; set; }

    public string CrossRefID { get; set; }

    public int CrossRefSource { get; set; }

    public int CrossRefType { get; set; }

    public object Clone() =>
        new CL_CrossRef_AniDB_Other
        {
            CrossRef_AniDB_OtherID = CrossRef_AniDB_OtherID,
            AnimeID = AnimeID,
            CrossRefID = CrossRefID,
            CrossRefSource = CrossRefSource,
            CrossRefType = CrossRefType
        };
}
