using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using System.Collections.Generic;

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
