using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class BowlingInning : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int BowlingInningID { get; set; }

        private readonly IList<BowlerInning> bowlerInnings = new List<BowlerInning>();
        public virtual IList<BowlerInning> BowlerInnings
        {
            get { return bowlerInnings; }
        }
    }
}
