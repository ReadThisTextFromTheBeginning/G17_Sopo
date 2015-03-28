using Sopo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public sealed class LogRepository : RepositoryBase<Log>
    {
        public void LoginLog(User user)
        {
            Save(new Log()
            {
                Date = DateTime.Now,
                Text = string.Format("{0}-th User Username:{1}  was  was Logged In.", user.ID, user.Username),
            });
        }
        public void LogOutLog(User user)
        {
            Save(new Log()
            {
                Date = DateTime.Now,
                Text = string.Format("{0}-th User Username:{1} was Logged Out.", user.ID, user.Username),
            });
        }
        public void RegisterLog(User user)
        {
            Save(new Log()
            {
                Date = DateTime.Now,
                Text = string.Format("{0}-th User was Registered with Username:{1}.", user.ID, user.Username),
            });
        }
        public void ExceptionLog(Exception ex)
        {
            Save(new Log() { 
            Date = DateTime.Now,
            Text = ex.Message,
            });
        }
    }
}
