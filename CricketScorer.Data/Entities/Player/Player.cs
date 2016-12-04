using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class Player : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual string FirstNames { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Initials { get; set; }
        public virtual string NameKnownAs { get; set; }
        public virtual Hand BattingHand { get; set; }

        private readonly IList<PlayerBowling> bowlingStyles = new List<PlayerBowling>();
        public virtual IList<PlayerBowling> BowlingStyles
        {
            get { return bowlingStyles; }
        }

        private readonly IList<PlayerRole> roles = new List<PlayerRole>();
        public virtual IList<PlayerRole> Roles
        {
            get { return roles; }
        }

        private readonly IList<Team> teams = new List<Team>();
        public virtual IList<Team> Teams
        {
            get { return teams; }
        }
    }
}
