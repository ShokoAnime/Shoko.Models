using System;
using System.Collections.Generic;
using System.Text;

namespace Shoko.Models.WebCache
{
    public class WebCache_FileHash_Collision
    {
        public int WebCache_FileHash_Collision_Id { get; set; }
        public string WebCache_FileHash_Collision_Unique { get; set; }
        public int AniDBUserId { get; set; }
        public bool CollisionApproved { get; set; }
        public DateTime CreationDate { get; set; }
        public string ED2K { get; set; }
        public string CRC32 { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public long FileSize { get; set; }
    }
}
