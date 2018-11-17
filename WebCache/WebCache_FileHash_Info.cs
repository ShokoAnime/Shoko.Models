using System;

namespace Shoko.Models.WebCache
{
    public class WebCache_FileHash_Info : WebCache_FileHash
    {
        public int AniDBUserId { get; set; }

        public bool CollisionApproved { get; set; }

        public DateTime CreationDate { get; set; }

    }
}