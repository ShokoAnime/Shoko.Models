﻿using System;
using System.Collections.Generic;
using Shoko.Models.PlexAndKodi;

namespace Shoko.Models.Client;

public class CL_VideoDetailed
{
    public int AnimeEpisodeID { get; set; }

    #region Cross-reference

    public int Percentage { get; set; }

    public int EpisodeOrder { get; set; }

    public int CrossRefSource { get; set; }

    #endregion

    #region Video

    public int VideoLocalID { get; set; }

    public string VideoLocal_FileName { get; set; }

    public string VideoLocal_Hash { get; set; }

    public long VideoLocal_FileSize { get; set; }

    public int VideoLocal_IsWatched { get; set; }

    public DateTime? VideoLocal_WatchedDate { get; set; }

    public long VideoLocal_ResumePosition { get; set; }

    public int VideoLocal_IsIgnored { get; set; }

    public string VideoLocal_CRC32 { get; set; }

    public string VideoLocal_MD5 { get; set; }

    public string VideoLocal_SHA1 { get; set; }

    public int VideoLocal_HashSource { get; set; }

    public int VideoLocal_IsVariation { get; set; }

    public List<CL_VideoLocal_Place> Places { get; set; }

    #endregion

    #region Video/media Info

    public string VideoInfo_VideoCodec { get; set; }

    public string VideoInfo_VideoBitrate { get; set; }

    public string VideoInfo_VideoBitDepth { get; set; }

    public string VideoInfo_VideoFrameRate { get; set; }

    public string VideoInfo_VideoResolution { get; set; }

    public string VideoInfo_AudioCodec { get; set; }

    public string VideoInfo_AudioBitrate { get; set; }

    public long VideoInfo_Duration { get; set; }

    #endregion

    #region Media

    public Media Media { get; set; }

    #endregion

    #region AniDB File
        
    public int? AniDB_FileID { get; set; }

    public int? AniDB_AnimeID { get; set; }

    public int? AniDB_GroupID { get; set; }

    public string AniDB_File_Source { get; set; }

    public string AniDB_File_AudioCodec { get; set; }

    public string AniDB_File_VideoCodec { get; set; }

    public string AniDB_File_VideoResolution { get; set; }

    public string AniDB_File_FileExtension { get; set; }

    public int? AniDB_File_LengthSeconds { get; set; }

    public string AniDB_File_Description { get; set; }

    public int? AniDB_File_ReleaseDate { get; set; }

    public string AniDB_Anime_GroupName { get; set; }

    public string AniDB_Anime_GroupNameShort { get; set; }

    public int? AniDB_Episode_Rating { get; set; }

    public int? AniDB_Episode_Votes { get; set; }

    public string AniDB_CRC { get; set; }

    public string AniDB_MD5 { get; set; }

    public string AniDB_SHA1 { get; set; }

    public int AniDB_File_FileVersion { get; set; }

    public int AniDB_File_IsCensored { get; set; }

    public int AniDB_File_IsDeprecated { get; set; }

    public int AniDB_File_IsChaptered { get; set; }

    public int AniDB_File_InternalVersion { get; set; }

    public string LanguagesAudio { get; set; }

    public string LanguagesSubtitle { get; set; }

    #endregion

    #region AniDB Release Group

    public CL_AniDB_ReleaseGroup ReleaseGroup { get; set; }

    #endregion
}
