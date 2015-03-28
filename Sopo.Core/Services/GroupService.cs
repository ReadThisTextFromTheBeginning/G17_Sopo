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
    public sealed class GroupService : Sopo.Core.Services.ServiceBase<Sopo.Domain.Group, GroupRepository>
    {
        public GroupService(IUnitOfWork contextObj, GroupRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
