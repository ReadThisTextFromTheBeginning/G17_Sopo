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
    public sealed class ProfileService : ServiceBase<Sopo.Domain.Profile, ProfileRepository>
    {
        public ProfileService(IUnitOfWork contextObj, ProfileRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
