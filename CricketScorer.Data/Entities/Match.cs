using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Match : IVersionedEntity
    {
        public byte[] Version { get; set;}

        public DateTime MatchDate;
    }
}
