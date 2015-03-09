using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sopo.Repository;

namespace Sopo.Test
{
    [TestClass]
    public class UserRepositoryTest : TestBase
    {
        private UserRepository _userRepository;

        public UserRepositoryTest()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod]
        public void ReadWriteDeleteTest()
        {
            User u = new User()
            {
                Email = "testuser@tests.com",
                Password = "TestPass",
                FirstName = "TestFirstName",
                LastName = "TestLastName",
            };

            _context.Users.Add(u);
            _context.SaveChanges();

            u = _context.Users.FirstOrDefault(x => x.Email == "testuser@tests.com");

            Assert.IsNotNull(u, "User wasn't created!");

            _userRepository.Delete(u.ID);

            _context.SaveChanges();

            if (_context.Users.FirstOrDefault(x => x.Email == u.Email) != null)
            {
                Assert.IsTrue(_context.Users.FirstOrDefault(x => x.Email == u.Email).IsDeleted == true, "Test user was not deleted!");
            }
        }
    }
}