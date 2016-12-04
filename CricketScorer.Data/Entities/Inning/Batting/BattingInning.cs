using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class BattingInning : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int BattingInningID { get; set; }

        private readonly IList<BatsmanInning> batsmanInnings = new List<BatsmanInning>();
        public virtual IList<BatsmanInning> BatsmanInnings
        {
            get { return batsmanInnings; }
        }
    }
}
