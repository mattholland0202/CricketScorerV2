using System.Collections.Generic;

namespace CricketScorer.Data.Entities
{
    public class Inning : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual BattingInning Batting { get; set; }
        public virtual BowlingInning Bowling { get; set; }
        public virtual int InningNumber { get; set; }
        public virtual int Runs { get; set; }
        public virtual int Wickets { get; set; }

        private readonly IList<Over> overs = new List<Over>();
        public virtual IList<Over> Overs
        {
            get { return overs; }
        }
    }
}
