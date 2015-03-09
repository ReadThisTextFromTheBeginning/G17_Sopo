using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository.Enums
{
    public enum RelationshipStatus
    {
        Rejected = -1,
        Requested = 0,
        Friend = 1,
        Unfriended = 2,
        Blocked = 3,
    }
}
