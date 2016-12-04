using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class BowlerInning : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int BowlerInningID { get; set; }
        public virtual Player Bowler { get; set; }
        public virtual double Overs { get; set; }
        public virtual int Maidens { get; set; }
        public virtual int Runs { get; set; }
        public virtual int Wickets { get; set; }
    }
}
