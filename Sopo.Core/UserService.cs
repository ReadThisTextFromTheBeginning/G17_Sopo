using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;
using Sopo.Domain;

namespace Sopo.Core {
	public sealed class UserService : ServiceBase {
        

		public User Login(string username, string password) {
			var u = _userRepository.Set().FirstOrDefault(x => x.Email == username && x.Password == password);
			if(u != null) _logRepository.LoginLog(u);
			return u;
		}

        public User Register(User user)
        {
            return user;
        }
	}
}