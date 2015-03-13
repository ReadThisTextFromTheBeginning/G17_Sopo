using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain.BaseTypes
{
    public abstract class BaseRecord
    {
        public BaseRecord()
        {

        }
        [Key]
        public int ID { get; set; }
    }
}
