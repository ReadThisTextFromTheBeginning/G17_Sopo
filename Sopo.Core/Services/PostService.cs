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
    public sealed class PostService : ServiceBase<Sopo.Domain.Post, PostRepository>
    {
        public PostService(IUnitOfWork contextObj, PostRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
