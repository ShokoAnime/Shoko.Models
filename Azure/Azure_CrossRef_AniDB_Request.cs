

using Shoko.Models.Server;

namespace Shoko.Models.Azure
{
    public class Azure_CrossRef_AniDB_Request : CrossRef_AniDB
    {
        public string AnimeName { get; set; }
        public string Username { get; set; }
        public string AuthGUID { get; set; }
    }
}