using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;
using Sopo.Repository;

namespace Sopo.Core {
	public class UserService {
		protected UserRepository _userRepository;
		protected LogRepository _logRepository;

		public UserService() {
			//var db = new SopoContext();
			_userRepository = new UserRepository();
			_logRepository = new LogRepository();
		}

		public User Login(string username, string password) {
			var u = _userRepository.Set().FirstOrDefault(x => x.Email == username && x.Password == password);
			if(u != null) _logRepository.LoginLog(u);
			return u;
		}
	}
}
