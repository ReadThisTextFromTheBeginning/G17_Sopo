using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sopo.Repository;
using Sopo.Domain;

namespace Sopo.Test
{
    [TestClass]
    public class UserRepositoryTest : TestBase
    {
        [SetUp]
        public void SetUp() { }
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
                Username = "testuser@tests.com",
                Password = "TestPass",
                FirstName = "TestFirstName",
                LastName = "TestLastName",
            };

            _context.Users.Add(u);
            _context.SaveChanges();

            u = _context.Users.FirstOrDefault(x => x.Username == "testuser@tests.com");

            Assert.IsNotNull(u, "User wasn't created!");

            _userRepository.Delete(u.ID);

            _context.SaveChanges();

            if (_context.Users.FirstOrDefault(x => x.Username == u.Username) != null)
            {
                Assert.IsTrue(_context.Users.FirstOrDefault(x => x.Username == u.Username).IsDeleted == true, "Test user was not deleted!");
            }
        }
    }
}