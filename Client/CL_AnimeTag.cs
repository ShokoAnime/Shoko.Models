﻿using System;

namespace Shoko.Models.Client;

public class CL_AnimeTag : ICloneable
{
    public int TagID { get; set; }

    public int LocalSpoiler { get; set; }

    public int GlobalSpoiler { get; set; }

    public int Weight { get; set; }

    // Not really pretty, but much prettier than replacing the entire CL_ tree with VMs
    private string tagName;

    public string TagName
    {
        get => tagName == null ? null : string.Intern(tagName);
        set => tagName = value == null ? null : string.Intern(value);
    }

    private string tagDescription;

    public string TagDescription
    {
        get => tagDescription == null ? null : string.Intern(tagDescription);
        set => tagDescription = value == null ? null : string.Intern(value);
    }

    public object Clone() =>
        new CL_AnimeTag
        {
            TagID = TagID,
            LocalSpoiler = LocalSpoiler,
            GlobalSpoiler = GlobalSpoiler,
            Weight = Weight,
            tagName = tagName,
            tagDescription = tagDescription
        };
}
