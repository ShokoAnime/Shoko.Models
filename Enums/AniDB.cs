﻿using System;

namespace Shoko.Models.Enums
{
    public enum AiringState
    {
        All = 0,
        StillAiring = 1,
        FinishedAiring = 2,
    }

    public enum AniDBFileDeleteType
    {
        Delete = 0,
        DeleteLocalOnly = 1,
        MarkDeleted = 2,
        MarkExternalStorage = 3,
        MarkUnknown = 4,
        MarkDisk = 5
    }

    public enum AniDBFile_State
    {
        Unknown,
        HDD,
        Disk,
        Deleted,
        Remote
    }

    [Flags]
    public enum AniDBFileFlags
    {
        None = 0,
        FILE_CRCOK = 1, //file matched official CRC (displayed with green background in AniDB)
        FILE_CRCERR = 2, // file DID NOT match official CRC (displayed with red background in AniDB)
        FILE_ISV2 = 4, // file is version 2
        FILE_ISV3 = 8, // file is version 3
        FILE_ISV4 = 16, // file is version 4
        FILE_ISV5 = 32, // file is version 5
        FILE_UNC = 64, // file is uncensored
        FILE_CEN = 128, // file is censored
        FILE_CHAPTERED = 4096 // file is chaptered, 0 means both not set and false
    }

    public enum AniDBUpdateType
    {
        None = 0,
        UDPBan = 1,
        HTTPBan = 2,
        Invalid_Session = 3,
        Overload_Backoff = 4,
        WaitingOnResponse = 5,
    }

    public enum AniDBRecommendationType
    {
        ForFans = 1,
        Recommended = 2,
        MustSee = 3,
    }

    public enum AniDBVoteType
    {
        Anime = 1,
        AnimeTemp = 2,
        Group = 3,
        Episode = 4
    }

    public enum AniDB_ResourceLinkType
    {
        ANN = 1,
        MAL = 2, // MAL ID, there may be more than one
        AnimeNFO = 3, // Dead site.
        Site_JP = 4, // Official Japanese Site
        Site_EN = 5, // Official English Site
        Wiki_EN = 6, // wikipedia.com
        Wiki_JP = 7, // wikipedia.jp
        Syoboi = 8, // Airing Schedule (Japanese site)
        ALLCinema = 9,
        Anison = 10,
        DotLain = 11, // .lain (JP VA and anime site)
        VNDB = 14, // The Visual Novel Database, for related VN game, if any.
        Crunchyroll = 28, // Series page, not episodes
        Amazon = 32, // amazon.com
        Funimation = 34, // See Crunchyroll comment ☝
        Bangumi = 38, // Japanese site
        HiDive = 42, // Streaming service, series page.
    }
    public enum EpisodeSourceType
    {
        File = 1,
        Episode = 2,
        HTTPAPI = 3
    }

    public enum CharacterAppearanceType
    {
        Main_Character,
        Minor_Character,
        Background_Character,
        Cameo
    }
}
