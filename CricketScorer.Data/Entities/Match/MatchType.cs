using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class MatchType : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int MatchTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsLimitedOvers { get; set; }
        public virtual int? MaxOversPerSide { get; set; }
        public virtual bool IsInternational { get; set; }
        public virtual bool IsMultiInning { get; set; } 
    }
}