using System.Collections.Generic;

namespace Shoko.Models.WebCache
{
    public class WebCache_AnimeFull
    {
        public WebCache_AnimeDetail Detail { get; set; }
        public List<WebCache_AnimeCharacter> Characters { get; set; } = new List<WebCache_AnimeCharacter>();
        public List<WebCache_AnimeComment> Comments { get; set; } = new List<WebCache_AnimeComment>();
    }
}