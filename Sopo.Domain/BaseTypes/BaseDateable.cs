using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository.BaseTypes
{
    public abstract class BaseDateable : BaseRecord, IDateable
    {
        public DateTime Date { get; set; }
    }
}
