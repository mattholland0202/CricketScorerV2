using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class PlayerBowling : IVersionedEntity
    {
        public virtual byte[] Version { get; set; } 
        public virtual Player Player { get; set; } // TODO: How to create joint PK in FNH?
        public virtual BowlingType BowlingType { get; set; }
        public virtual bool IsPrimary { get; set; }
    }
}
