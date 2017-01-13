﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoko.Models.Client
{
    public class CL_MainChanges
    {
        public Client.CL_Changes<CL_GroupFilter> Filters { get; set; }=new Client.CL_Changes<CL_GroupFilter>();
        public Client.CL_Changes<Client.CL_AnimeGroup_User> Groups { get; set; }=new Client.CL_Changes<Client.CL_AnimeGroup_User>();
        public Client.CL_Changes<Client.CL_AnimeSeries_User> Series { get; set; }=new Client.CL_Changes<Client.CL_AnimeSeries_User>();
        public DateTime LastChange { get; set; }
    }
}