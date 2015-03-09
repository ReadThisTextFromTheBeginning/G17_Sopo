using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Repository
{
    public class Page : BaseRateable
    {
        public string Name { get; set; }
        public PageType Type { get; set; }

        //Coming soon...

        public virtual User User { get; set; }
    }
}
