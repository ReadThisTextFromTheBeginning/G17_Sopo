using Sopo.Repository.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sopo.Repository
{
    public class Phone : BaseDeletable
    {
        public string Text { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Country Country { get; set; }

        public override string ToString()
        {
            return this.Country.PhonePrefix + this.Text;
        }

    }
}
