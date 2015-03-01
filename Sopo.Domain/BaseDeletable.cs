using Sopo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain {
	public abstract class BaseDeletable : BaseRecord, IDeletable {
		public bool IsDeleted { get; set; }
	}
}
