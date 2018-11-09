using System;
using System.Collections.Generic;
using System.Text;
using Shoko.Models.Enums;

namespace Shoko.Models.WebCache
{
    public class WebCache_Reliability<T>
    {
        public WebCache_ReliabilityType Type { get; set; }

        public T Result { get; set; }

        public int PopularityCount { get; set; }
    }
}
