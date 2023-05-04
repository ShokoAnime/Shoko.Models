using System;

namespace Shoko.Models.Client;

public class CL_Trakt_Comment
{
    #region General

    /// <summary>
    /// E.g. "episode", "show", etc.
    /// </summary>
    public int CommentType { get; set; }

    public string Text { get; set; }

    public bool Spoiler { get; set; }

    public DateTime? Inserted { get; set; }

    public string Comment_Url { get; set; }

    #endregion

    #region Episode

    public string Episode_Season { get; set; }

    public string Episode_Number { get; set; }

    public string Episode_Title { get; set; }

    public string Episode_Overview { get; set; }

    public string Episode_Url { get; set; }

    public string Episode_Screenshot { get; set; }

    #endregion

    #region Episode or Show

    public CL_TraktTVShowResponse TraktShow { get; set; }

    public int? AnimeSeriesID { get; set; }

    public CL_AniDB_Anime Anime { get; set; }

    #endregion
}
