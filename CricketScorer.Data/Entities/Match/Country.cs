using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Country
    {
        public virtual int CountryID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
    }
}
