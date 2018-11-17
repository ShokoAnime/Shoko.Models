using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Shoko.Models.MediaInfo
{
    [DataContract]
    public class MediaInfo
    {
        [DataMember(EmitDefaultValue = false)]
        public Media Media { get; set; }
    }
}
