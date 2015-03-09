using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository.BaseTypes
{
    public abstract class BaseDeletable : BaseDateable, IDeletable
    {
        public bool IsDeleted { get; set; }
    }
}
