using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class MatchLocation : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int MatchLocationID { get; set; }
        public virtual string GroundName { get; set; }
        public virtual Country Country { get; set; }
    }
}
