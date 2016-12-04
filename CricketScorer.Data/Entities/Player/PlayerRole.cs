using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class PlayerRole : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual Player Player { get; set; }
        public virtual PlayerRoleType RoleType { get; set; }
        public virtual bool IsPrimary { get; set; }
    }
}
