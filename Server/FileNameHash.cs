﻿using System;

namespace Shoko.Models.Server
{
    public class FileNameHash
    {
        public FileNameHash()
        {
        }
        public int FileNameHashID { get; private set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string Hash { get; set; }
        public DateTime DateTimeUpdated { get; set; }

    }
}