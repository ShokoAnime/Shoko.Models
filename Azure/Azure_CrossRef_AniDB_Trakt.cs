using Shoko.Models.Server;

namespace Shoko.Models.Client
{
    public class CL_Azure_CrossRef_AniDB_Trakt : CL_CrossRef_AniDB_Trakt
    {
        public string AnimeName { get; set; }
        public string Username { get; set; }
        public int IsAdminApproved { get; set; }
        public long DateSubmitted { get; set; }

    }
}
