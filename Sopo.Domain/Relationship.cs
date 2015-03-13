using Sopo.Domain.BaseTypes;
using Sopo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    public class Relationship : BaseDateable
    {
        public RelationshipStatus RelationStatus { get; set; }
        public virtual User ActionUser { get; set; }
        public virtual User OtherUser { get; set; }
    }
}
