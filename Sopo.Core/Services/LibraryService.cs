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
    public sealed class LibraryService : Sopo.Core.Services.ServiceBase<Sopo.Domain.Library, LibraryRepository>
    {
        public LibraryService(IUnitOfWork contextObj, LibraryRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
