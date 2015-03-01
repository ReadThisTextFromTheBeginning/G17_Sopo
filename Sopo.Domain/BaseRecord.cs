using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain {
	public abstract class BaseRecord {
		[Key]
		public int ID { get; set; }
	}
}
