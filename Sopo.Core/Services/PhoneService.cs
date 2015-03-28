using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;
using Sopo.Domain;
using Sopo.Domain.Interfaces;
namespace Sopo.Core.Services
{
    public sealed class PhoneService : ServiceBase<Sopo.Domain.Phone, PhoneRepository>
    {
        public PhoneService(IUnitOfWork contextObj, PhoneRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
