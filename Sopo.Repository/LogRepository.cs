using Sopo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository {
	public class LogRepository : RepositoryBase<Log> {
		public void LoginLog(User user) {
			Save(new Log() {
				Date = DateTime.Now,
				Text = string.Format("User {0} ({1}) was logged.", user.Email, user.ID)
			});
		}
	}
}
