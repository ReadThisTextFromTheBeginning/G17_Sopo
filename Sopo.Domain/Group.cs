using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class Group : BaseRateable
    {
        public Group()
        {
            Users = new List<User>();
        }

        public string Name { get; set; }
        public GroupType GroupType { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
