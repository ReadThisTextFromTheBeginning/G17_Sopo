using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain {
	public class Friend {
		[Key]
		public int ID { get; set; }

		public virtual User Contact { get; set; }
	}
}
