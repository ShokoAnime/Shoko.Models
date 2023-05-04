using System;
using System.Collections.Generic;

namespace Shoko.Models.Client;

public class CL_Changes<T>
{
    public List<T> ChangedItems { get; set; } = new();

    public List<int> RemovedItems { get; set; } = new();

    public DateTime LastChange { get; set; }
}
