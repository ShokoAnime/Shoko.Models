﻿
namespace Shoko.Models.Client;

public class CL_Playlist
{
    public int PlaylistID { get; set; }

    public string PlaylistName { get; set; }

    public string PlaylistItems { get; set; }

    public int DefaultPlayOrder { get; set; }

    public int PlayWatched { get; set; }

    public int PlayUnwatched { get; set; }
}

