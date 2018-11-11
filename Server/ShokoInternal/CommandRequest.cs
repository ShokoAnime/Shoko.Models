using System;
using System.Collections.Generic;
using System.Text;

namespace Shoko.Models.Server
{
    public class CommandRequest
    {
    #region Server DB columns

        public string Id { get; set; }
        public string Class { get; set; }
        public int Type { get; set; }
        
        public string ParallelTag { get; set; }
        public int ParallelMax { get; set; }
        public int Priority { get; set; }
        public string Batch { get; set; }
        public DateTime ExecutionDate { get; set; }
        public int Retries { get; set; }
        public string LastError { get; set; }
        public string Data { get; set; }
        public int RetryFutureSeconds { get; set; }
        public string PreconditionClass1 { get; set; }
        public string PreconditionClass2 { get; set; }
        public string PreconditionClass3 { get; set; }
        public string PreconditionClass4 { get; set; }
        public string PreconditionClass5 { get; set; }
        public string PreconditionClass6 { get; set; }
    #endregion

    }
}
