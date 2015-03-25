using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Interfaces;
using Sopo.Repository;
using Sopo.Domain;
namespace Sopo.Core.Services
{
    public sealed class ProfileService : ServiceBase<Profile, ProfileRepository>
    {
        public ProfileService(IUnitOfWork contextObj, ProfileRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
