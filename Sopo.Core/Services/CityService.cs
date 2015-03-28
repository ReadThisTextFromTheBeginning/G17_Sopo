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
    public sealed class CityService : Sopo.Core.Services.ServiceBase<Sopo.Domain.City, CityRepository>
    {
       public CityService(IUnitOfWork contextObj, CityRepository repositoryObj)
           : base(contextObj, repositoryObj)
       {

       }
    }
}
