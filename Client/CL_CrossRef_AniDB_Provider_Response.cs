using Shoko.Models.Server.CrossRef;
using Shoko.Models.WebCache;

namespace Shoko.Models.Client
{
    public class CL_CrossRef_AniDB_Provider_Response : CrossRef_AniDB_Provider
    {
        public int IsAdminApproved { get; set; }
    }
}