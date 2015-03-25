using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;
using Sopo.Domain;
using Sopo.Interfaces;

namespace Sopo.Core.Services
{
    public sealed class UserService : ServiceBase<User, UserRepository>
    {
        public UserService(IUnitOfWork contextObj, UserRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {
            //_context = contextObj;
            //_repository = repositoryObj;
        }

        public User Login(string username, string password)
        {
            var u = this.Set().FirstOrDefault(x => x.Email == username && x.Password == password);
            //if(u != null) _logRepository.LoginLog(u);
            return u;
        }

        public User Register(User user)
        {
            var u = this.Set().SingleOrDefault(x => x.Email == user.Email && x.Password == user.Password);     //?
            if (u == null)this.Save(user);
            else return null;   
            return user;
        }
    }
}