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
    public sealed class RelationshipService : ServiceBase<Relationship, RelationshipRepository>
    {
        public RelationshipService(IUnitOfWork contextObj, RelationshipRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {
        }
    }
}
