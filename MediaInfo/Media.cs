using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Shoko.Models.MediaInfo
{
    [DataContract]
    public class Media
    {
        [DataMember(EmitDefaultValue = false, Name = "@ref")]
        public string Reference { get; set; }
        [DataMember(EmitDefaultValue = false, Name = "track")]
        public List<Track> Tracks { get; set; }
    }
}
