using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain.BaseTypes
{[ComplexType]
    public abstract class BaseRateable : BaseDeletable, IRateable
    {
        public ICollection<Rating> Rating { get; set; }
    }
}
