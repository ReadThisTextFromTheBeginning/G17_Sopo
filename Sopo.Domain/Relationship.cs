using Sopo.Repository.BaseTypes;
using Sopo.Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Repository
{
    public class Relationship : BaseDateable
    {
        public RelationshipStatus RelationStatus { get; set; }
        public virtual User ActionUser { get; set; }
        public virtual User OtherUser { get; set; }
    }
}
