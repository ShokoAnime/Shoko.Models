using System.Collections.Generic;

#nullable enable
namespace Shoko.Models.Server;

/// <summary>
/// User model.
/// </summary>
public class JMMUser
{
    /// <summary>
    /// Local user id.
    /// </summary>
    public int JMMUserID { get; set; }

    /// <summary>
    /// Username.
    /// </summary>
    public string Username { get; set; } = "";

    /// <summary>
    /// Encrypted password. Can be empty if no password is set.
    /// </summary>
    public string Password { get; set; } = "";

    /// <summary>
    /// True if the user is a system administrator.
    /// </summary>
    public bool IsAdmin { get; set; }

    /// <summary>
    /// True if this user's watch state is synced with AniDB.
    /// </summary>
    public bool IsAniDBUser { get; set; }

    /// <summary>
    /// True is this user's watch state is synced with Trakt.
    /// </summary>
    public bool IsTraktUser { get; set; }

    /// <summary>
    /// Restricted tags. Any group/series containing any of these tags will be
    /// rendered inaccessible to the user.
    /// </summary>
    public HashSet<string> RestrictedTags { get; set; } = new();
}
