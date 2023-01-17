using System;

namespace Shoko.Models.Client;

/// <summary>
/// User model.
/// </summary>
public class CL_JMMUser
{
    /// <summary>
    /// Local user id.
    /// </summary>
    public int JMMUserID { get; set; }

    /// <summary>
    /// Username.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Encrypted password. Can be empty if no password is set.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// True if the user is a system administrator.
    /// </summary>
    public int IsAdmin { get; set; }

    /// <summary>
    /// True if this user's watch state is synced with AniDB.
    /// </summary>
    public int IsAniDBUser { get; set; }

    /// <summary>
    /// True is this user's watch state is synced with Trakt.
    /// </summary>
    public int IsTraktUser { get; set; }

    /// <summary>
    /// Restricted tags. Any group/series containing any of these tags will be
    /// rendered inaccessible to the user.
    /// </summary>
    public string HideCategories { get; set; }

    /// <summary>
    /// Was used to give the user access to edit the server settings.
    /// </summary>
    [Obsolete("Not in use anymore.")]
    public int? CanEditServerSettings { get; set; }

    /// <summary>
    /// A list of local Plex usernames to sync with the current Shoko user
    /// through the Plex web-hook.
    /// </summary>
    /// <remarks>
    /// You only need to configure this setting if you haven't linked your Shoko
    /// account to your Plex account.
    /// </remarks>
    public string PlexUsers { get; set; }

    /// <summary>
    /// Setting (or viewing) the plex token is now not
    /// </summary>
    /// <value></value>
    [Obsolete("Not in use anymore.")]
    public string PlexToken { get; set; }
}
