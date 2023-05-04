using System;

namespace Shoko.Models.Client;

public class CL_AniDB_Vote : ICloneable
{
    public int AniDB_VoteID { get; set; }

    public int EntityID { get; set; }

    /// <remarks>
    /// The value should be divided by 100 in the Shoko Desktop.
    /// </remarks>
    public int VoteValue { get; set; }

    public int VoteType { get; set; }

    public object Clone() =>
        new CL_AniDB_Vote
        {
            AniDB_VoteID = AniDB_VoteID,
            EntityID = EntityID,
            VoteValue = VoteValue,
            VoteType = VoteType
        };
}
