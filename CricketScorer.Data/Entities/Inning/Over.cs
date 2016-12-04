using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Over : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int OverID { get; set; }
        public virtual int OverNumber { get; set; }

        private readonly IList<Ball> balls = new List<Ball>();
        public virtual IList<Ball> Balls
        {
            get { return balls; }
        }
    }
}
