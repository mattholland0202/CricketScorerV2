using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class BowlingType
    {
        public virtual int BowlingTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Hand Hand { get; set; }
        public virtual bool IsSpin { get; set; }
    }
}
