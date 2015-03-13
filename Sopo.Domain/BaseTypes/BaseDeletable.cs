using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain.BaseTypes
{[ComplexType]
    public abstract class BaseDeletable : BaseDateable, IDeletable
    {
        public bool IsDeleted { get; set; }
    }
}
