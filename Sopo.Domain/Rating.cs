using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Sopo.Repository
{
    public class Rating : BaseDeletable
    {
        public RatingScale Rate { get; set; }

        public virtual User User { get; set; }
        public virtual IRateable Item { get; set; }
    }
}
