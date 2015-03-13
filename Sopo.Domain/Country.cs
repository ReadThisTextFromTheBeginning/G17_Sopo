using Sopo.Domain.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain
{
    public class Country : BaseRecord
    {
        public Country()
        {
            Cities = new List<City>();
        }
        public string Name { get; set; }
        public string PhonePrefix { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
