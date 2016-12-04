using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScorer.Data.Entities
{
    public class PlayerRoleType
    {
        public virtual int PlayerRoleID { get; set; }
        public virtual PlayerRoleType ParentRole { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
    }
}
