using Sopo.Domain.BaseTypes;
using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
    public class Picture : BaseRateable
    {
        public string Description { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string FilePath { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Library Library { get; set; }
    }
}
