using System;

namespace Shoko.Models.Client;

public class CL_CustomTag : ICloneable
{
    public int CustomTagID { get; set; }

    public string TagName { get; set; }

    public string TagDescription { get; set; }

    public object Clone() =>
        new CL_CustomTag
        {
            CustomTagID = CustomTagID,
            TagName = TagName,
            TagDescription = TagDescription
        };
}
