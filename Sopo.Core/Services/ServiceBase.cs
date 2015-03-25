using Sopo.Domain.Interfaces;
using Sopo.Domain;
using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Core;
using Sopo.Interfaces;

namespace Sopo.Core.Services
{   //:D dzaan momewona es klasi
    public abstract class ServiceBase<T, K> : IService<T> 
        where T : class, new()
        where K : IRepository<T>
    {
        protected IUnitOfWork _context;
        protected K _repository;

        public ServiceBase(IUnitOfWork context, K repository)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (repository == null) throw new ArgumentNullException("repository");
            _context = context;
            _repository = repository;
        }

        public virtual T Fetch(int id)
        {
            return _repository.Fetch(id);
        }

        public IEnumerable<T> Set()
        {
            return _repository.Set();
        }

        public void Save(T entity)
        {
            _repository.Save(entity);
            _context.Commit();
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
            _context.Commit();
        }

        public virtual void Delete(T entity)
        {
            _repository.Delete(entity);
            _context.Commit();
        }
    }
}