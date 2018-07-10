using System;

namespace Shoko.Models.Server
{
    public class Scan
    {
        public int ScanID { get; set; }
        public DateTime CreationTime { get; set; }
        public string ImportFolders { get; set; }
        public int Status { get; set; }

        public Scan()
        {
            
        }
    }
}
