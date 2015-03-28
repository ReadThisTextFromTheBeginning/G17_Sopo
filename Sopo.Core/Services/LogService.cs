using Sopo.Domain;
using Sopo.Domain.Interfaces;
using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Core.Services
{
    internal sealed class LogService : ServiceBase<Log, LogRepository>
    {
        public LogService(IUnitOfWork contextObj, LogRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }

        internal void CreateLog(string text)
        {
            Log log = new Log() { Date = DateTime.Now, Text = text };
            this.Save(log);
        }
    }
}
