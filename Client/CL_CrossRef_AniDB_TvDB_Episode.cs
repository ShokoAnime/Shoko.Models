using Shoko.Models.Enums;

namespace Shoko.Models.Client;

public class CL_CrossRef_AniDB_TvDB_Episode
{
    public int CrossRef_AniDB_TvDB_EpisodeID { get; set; }

    public int AniDBEpisodeID { get; set; }

    public int TvDBEpisodeID { get; set; }

    public MatchRating MatchRating { get; set; }
}
