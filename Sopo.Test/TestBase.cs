using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;

namespace Sopo.Test {
	public class TestBase {
		protected SopoContext _context;

		protected TestBase() {
			_context = new SopoContext();
		}
	}
}
