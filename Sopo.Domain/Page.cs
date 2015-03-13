using Sopo.Domain.BaseTypes;
using Sopo.Domain.Enums;
using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    public class Page : BaseRateable
    {
        public string Name { get; set; }
        public PageType Type { get; set; }

        //Coming soon...

        public virtual User OwnerUser { get; set; }
    }
}
