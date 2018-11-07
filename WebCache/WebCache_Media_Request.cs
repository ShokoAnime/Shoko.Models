

namespace Shoko.Models.WebCache
{
    public class WebCache_Media_Request
    {
        public string ED2K { get; set; }
        public byte[] MediaInfo { get; set; }
        public int Version { get; set; }
        public string Username { get; set; }
        public string AuthGUID { get; set; }
    }
}