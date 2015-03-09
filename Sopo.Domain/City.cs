using Sopo.Repository.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class City : BaseRecord
    {
        public City()
        {

        }
        public City(string name, TimeSpan gmtOffset)
        {
            this.Name = name;
            //this.GMToffset = gmtOffset;
            //this.LocalTime = DateTime.Now + GMToffset;
        }

        public string Name { get; set; }
        //public TimeSpan GMToffset { get; set; }
        public DateTime LocalTime { get; set; }
        public virtual Country Country { get; set; }
    }
}
