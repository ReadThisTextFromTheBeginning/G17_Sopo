using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sopo.Repository;
using Sopo.Domain;

namespace Sopo.Test {
	[TestClass]
	public class UserRepositoryTest : TestBase {
		private UserRepository _userRepository;

		public UserRepositoryTest() {
			_userRepository = new UserRepository();
		}

		[TestMethod]
		public void ReadWriteTest() {
			User u = new User() {
				Email = "testuser@tests.com",
				Password = "TestPass",
				FirstName = "TestFirstName",
				LastName = "TestLastName",
			};

			_context.Users.Add(u);
			_context.SaveChanges();

			Assert.IsNotNull(_context.Users.FirstOrDefault(x => x.Email == "testuser@tests.com"), "User wasn't created!");

		}
	}
}