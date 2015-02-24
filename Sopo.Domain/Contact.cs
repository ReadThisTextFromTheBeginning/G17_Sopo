using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain {
	public class Contact {
		[Key]
		public int ID { get; set; }

		[DataType(DataType.EmailAddress, ErrorMessage = "Incorrect email format!")]
		public string Email { get; set; }

		public virtual User User { get; set; }
	}
}
