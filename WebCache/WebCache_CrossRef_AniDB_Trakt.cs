using Shoko.Models.Server;

namespace Shoko.Models.WebCache
{
    public class WebCache_CrossRef_AniDB_Trakt : CrossRef_AniDB_TraktV2
    {
        public string AnimeName { get; set; }
        public string Username { get; set; }
        public int IsAdminApproved { get; set; }
        public long DateSubmitted { get; set; }

    }
}