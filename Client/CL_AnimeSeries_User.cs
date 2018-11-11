﻿using System;
using System.Collections.Generic;
using Shoko.Models.Server;
using Shoko.Models.Server.CrossRef;

namespace Shoko.Models.Client
{
    public class CL_AnimeSeries_User : AnimeSeries_User
    {
        public int AnimeGroupID { get; set; }
        public int AniDB_ID { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public string DefaultAudioLanguage { get; set; }
        public string DefaultSubtitleLanguage { get; set; }
        public DateTime? EpisodeAddedDate { get; set; }
        public DateTime? LatestEpisodeAirDate { get; set; }
        public int LatestLocalEpisodeNumber { get; set; }
        public string SeriesNameOverride { get; set; }

        public string DefaultFolder { get; set; }

        public int MissingEpisodeCount { get; set; }
        public int MissingEpisodeCountGroups { get; set; }
        public DayOfWeek? AirsOn { get; set; }

        public CL_AniDB_AnimeDetailed AniDBAnime { get; set; }
        public List<CL_CrossRef_AniDB_Provider> CrossRefAniDBTvDBV2 { get; set; }
        public CL_CrossRef_AniDB_Provider CrossRefAniDBMovieDB { get; set; }
        public List<CL_CrossRef_AniDB_Provider> CrossRefAniDBMAL { get; set; }
        public List<TvDB_Series> TvDB_Series { get; set; }
        public MovieDB_Movie MovieDB_Movie { get; set; }
        public CL_AnimeGroup_User TopLevelGroup { get; set; }
    }
}