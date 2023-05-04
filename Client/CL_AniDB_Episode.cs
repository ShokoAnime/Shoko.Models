using System;
using System.Collections.Generic;

namespace Shoko.Models.Client;

public class CL_AniDB_Episode
{
    public int AniDB_EpisodeID { get; set; }

    public int EpisodeID { get; set; }

    public int AnimeID { get; set; }

    public int LengthSeconds { get; set; }

    public string Rating { get; set; }

    public string Votes { get; set; }

    public int EpisodeNumber { get; set; }

    public int EpisodeType { get; set; }

    public string Description { get; set; }

    public int AirDate { get; set; }


    public DateTime DateTimeUpdated { get; set; }

    protected bool Equals(CL_AniDB_Episode other)
    {
        return EpisodeID == other.EpisodeID && AnimeID == other.AnimeID && LengthSeconds == other.LengthSeconds &&
                Rating == other.Rating && Votes == other.Votes && EpisodeNumber == other.EpisodeNumber &&
                EpisodeType == other.EpisodeType && Description == other.Description && AirDate == other.AirDate;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CL_AniDB_Episode)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = EpisodeID;
            hashCode = (hashCode * 397) ^ AnimeID;
            hashCode = (hashCode * 397) ^ LengthSeconds;
            hashCode = (hashCode * 397) ^ (Rating != null ? Rating.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Votes != null ? Votes.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ EpisodeNumber;
            hashCode = (hashCode * 397) ^ EpisodeType;
            hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ AirDate;
            return hashCode;
        }
    }

    // Map of language to title, using AniDB languages
    // TODO Make an ENUM for AniDB_Language
    public Dictionary<string, string> Titles { get; set; }
}
