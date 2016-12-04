using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Match : IVersionedEntity
    {
        public virtual byte[] Version { get; set;}
        public virtual int MatchID { get; set; }
        public virtual DateTime MatchDate { get; set; }
        public virtual MatchLocation MatchLocation { get; set; }
        public virtual MatchType MatchType { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
        public virtual bool IsNeutral { get; set; }

        private readonly IList<Inning> innings = new List<Inning>();
        public virtual IList<Inning> Innings
        {
            get { return innings; }
        }
    }
}
