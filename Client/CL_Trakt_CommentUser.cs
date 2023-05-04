
namespace Shoko.Models.Client;

public class CL_Trakt_CommentUser
{
    /// <summary>
    /// User details.
    /// </summary>
    public CL_Trakt_User User { get; set; }

    /// <summary>
    /// Comment details.
    /// </summary>
    public CL_Trakt_Comment Comment { get; set; }
}
