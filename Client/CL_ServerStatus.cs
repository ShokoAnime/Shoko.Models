using System;

namespace Shoko.Models.Client;

public class CL_ServerStatus
{
    public int HashQueueCount { get; set; }

    [Obsolete("Deprecated since 3.6.0.0")]
    public string HashQueueState { get; set; } = string.Empty;

    public int HashQueueStateId { get; set; }

    public string[] HashQueueStateParams { get; set; }

    public int GeneralQueueCount { get; set; }

    [Obsolete("Deprecated since 3.6.0.0")]
    public string GeneralQueueState { get; set; } = string.Empty;

    public int GeneralQueueStateId { get; set; }

    public string[] GeneralQueueStateParams { get; set; }

    public int ImagesQueueCount { get; set; }

    [Obsolete("Deprecated since 3.6.0.0")]
    public string ImagesQueueState { get; set; } = string.Empty;

    public int ImagesQueueStateId { get; set; }

    public string[] ImagesQueueStateParams { get; set; }

    public bool IsBanned { get; set; }

    public string BanReason { get; set; }

    public string BanOrigin { get; set; }
}
