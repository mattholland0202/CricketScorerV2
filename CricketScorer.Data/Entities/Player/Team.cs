using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Team : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int TeamID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual int MainColour { get; set; }
        public virtual int SecondaryColour { get; set; }
    }
}
