using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class MatchType : IVersionedEntity
    {
        public byte[] Version { get; set; }
    }
}
