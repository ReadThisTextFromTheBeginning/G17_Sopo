using Sopo.Domain.BaseTypes;
using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Domain
{
    public class Message : BaseDeletable
    {
        public string Text { get; set; }

        public virtual User Sender { get; set; }
        public virtual User Receiver { get; set; }
    }
}
