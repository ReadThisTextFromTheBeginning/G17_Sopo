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
    public sealed class PostService : ServiceBase<Post, PostRepository>
    {
        public PostService(IUnitOfWork contextObj, PostRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
