﻿using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository {
	public class UserRepository : RepositoryBase<User> {
		public override void Delete(User entity) {
			entity.IsDeleted = true;
		}
	}
}
