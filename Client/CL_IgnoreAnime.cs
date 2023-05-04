
namespace Shoko.Models.Client;

public class CL_IgnoreAnime
{
    public int IgnoreAnimeID { get; set; }

    public int JMMUserID { get; set; }

    public int AnimeID { get; set; }

    public int IgnoreType { get; set; }

    public CL_AniDB_Anime Anime { get; set; }
}

