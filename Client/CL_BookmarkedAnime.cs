
namespace Shoko.Models.Client;

public class CL_BookmarkedAnime
{
    public int BookmarkedAnimeID { get; set; }

    public int AnimeID { get; set; }

    public int Priority { get; set; }

    public string Notes { get; set; }

    public int Downloading { get; set; }

    public CL_AniDB_Anime Anime { get; set; }
}
