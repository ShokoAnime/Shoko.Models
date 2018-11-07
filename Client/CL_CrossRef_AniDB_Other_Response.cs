using Shoko.Models.WebCache;

namespace Shoko.Models.Client
{
    public class CL_CrossRef_AniDB_Other_Response : WebCache_CrossRef_AniDB_Other_Request
    {
        public int IsAdminApproved { get; set; }
    }
}