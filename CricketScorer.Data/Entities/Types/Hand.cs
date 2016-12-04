using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Hand
    {
        public virtual int HandID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Abbreviation { get; set; }
    }
}
