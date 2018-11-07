

using Shoko.Models.Server;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_Trakt_Request : CrossRef_AniDB_TraktV2
    {
        public string AnimeName { get; set; }
        public string Username { get; set; }
        public string AuthGUID { get; set; }

    }
}