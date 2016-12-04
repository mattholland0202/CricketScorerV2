using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Partnership : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PartnershipID { get; set; }
        public virtual Player Batsman1 { get; set; }
        public virtual Player Batsman2 { get; set; }
        public virtual int TotalRuns { get; set; }
    }
}
