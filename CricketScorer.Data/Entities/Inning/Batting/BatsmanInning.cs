using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class BatsmanInning : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int BatsmanInningID { get; set; }
        public virtual Player Batsman { get; set; }
        public virtual int Runs { get; set; }
        public virtual bool NotOut { get; set; }
        public virtual int BallsFaced { get; set; }
        public virtual int Minutes { get; set; }
        public virtual int Fours { get; set; }
        public virtual int Sixes { get; set; }

        private readonly IList<Partnership> partnerships = new List<Partnership>();
        public virtual IList<Partnership> Partnerships
        {
            get { return partnerships; }
        }
    }
}
