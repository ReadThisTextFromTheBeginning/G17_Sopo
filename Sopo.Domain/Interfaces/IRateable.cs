using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository.Interfaces
{
    public interface IRateable
    {
        ICollection<Rating> Rating { get; set; }
    }
}
