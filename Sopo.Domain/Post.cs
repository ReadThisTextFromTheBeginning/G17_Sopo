using Sopo.Domain.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
    public class Post : BaseDateable
    {
        public Post()
        {
            Images = new List<Picture>();
        }

        public string Name { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Picture> Images { get; set; }
        public virtual User Author { get; set; }
    }
}
