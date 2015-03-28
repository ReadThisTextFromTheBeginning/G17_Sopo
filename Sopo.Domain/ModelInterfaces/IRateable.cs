using Sopo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain.Interfaces
{
    public interface IRateable
    {
        ICollection<Rating> Rating { get; set; }
    }
}
