using Sopo.Domain;
using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Core
{
   internal sealed class LogService : ServiceBase
   {
       internal void CreateLog(string text)
       {
           Log log = new Log() { Date = DateTime.Now, Text = text };
           _logRepository.Save(log);
       }
    }
}
