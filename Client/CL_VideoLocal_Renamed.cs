
namespace Shoko.Models.Client;

public class CL_VideoLocal_Renamed
{
    public int VideoLocalID { get; set; }

    public CL_VideoLocal VideoLocal { get; set; }

    public string NewFileName { get; set; }

    /// <remarks>
    /// null if not moved, string with error if errored.
    /// </remarks>
    public string NewDestination { get; set; }

    public bool Success { get; set; }
}
