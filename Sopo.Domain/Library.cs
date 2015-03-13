using Sopo.Domain.BaseTypes;
using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
    public class Library : BaseDeletable
    {
        public Library()
        {
            Pictures = new List<Picture>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

    }
}
