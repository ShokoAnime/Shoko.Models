using System.Collections.Generic;

#nullable enable
namespace Shoko.Models.Server;

/// <summary>
/// Plex user settings model.
/// </summary>
public class JMMUser_Plex
{
    /// <summary>
    /// Present for database initialisation.
    /// </summary>
    public JMMUser_Plex() { }

    /// <summary>
    /// Create a new user Plex settings record for the given <paramref name="userID"/>.
    /// </summary>
    /// <param name="userID">User ID</param>
    public JMMUser_Plex(int userID) : base()
    {
        JMMUserID = userID;
    }

    /// <summary>
    /// Local Plex user settings id.
    /// </summary>
    public int JMMUser_PlexID { get; set; }

    /// <summary>
    /// Local Shoko user id. See <seealso cref="JMMUser"/>.
    /// </summary>
    public int JMMUserID { get; set; }

    /// <summary>
    /// The username of the account linked to the
    /// </summary>
    /// <remarks>
    /// Will be set/unset at the same time as the token.
    /// </remarks>
    public long? AccountID { get; set; }

    /// <summary>
    /// The current user's Plex token used to authenticate against the Plex
    /// api.
    /// </summary>
    /// <remarks>
    /// Will be set/unset at the same time as the account id.
    /// </remarks>
    public string? Token { get; set; }

    /// <summary>
    /// The selected server id in Plex.
    /// </summary>
    public string? SelectedServer { get; set; }

    /// <summary>
    /// The selected libraries relative to the selected server in Plex.
    /// </summary>
    /// <remarks>
    /// The library ids/keys are relative to the selected server and will
    /// therefore be automatically be unset if the selected server gets
    /// changed.
    /// </remarks>
    public HashSet<int> SelectedLibraries { get; set; } = new();

    /// <summary>
    /// A list of local Plex usernames to sync with the current Shoko user
    /// through the Plex web-hook.
    /// </summary>
    /// <remarks>
    /// You only need to configure this setting if you don't have a token/
    /// account-id set.
    /// </remarks>
    public HashSet<string> LocalUsers { get; set; } = new();
}
