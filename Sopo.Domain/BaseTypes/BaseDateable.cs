using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository.BaseTypes
{
    [ComplexType]
    public abstract class BaseDateable : BaseRecord, IDateable
    {
        public DateTime Date { get; set; }
    }
}
