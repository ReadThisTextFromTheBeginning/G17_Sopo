
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Domain.Interfaces;

namespace Sopo.Repository
{

    public abstract class RepositoryBase<T> : IRepository<T> where T : class ,new()
    {

        internal RepositoryBase(SopoContext context = null)
        {
            if (context == null) context = new SopoContext();

            _context = context;
        }

        protected SopoContext _context;

        public SopoContext Context
        {
            get { return _context; }
        }

        public virtual T Fetch(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> Set()
        {
            return _context.Set<T>();
        }

        public virtual void Save(T entity)
        {
            Save(_context.Set<T>(), entity);
        }

        protected virtual void Save(DbSet<T> set, T entity)
        {
            var entry = _context.Entry(entity);
            if (entry == null || entry.State == EntityState.Detached) set.Add(entity);
        }

        public virtual void Delete(int id)
        {
            Delete(Fetch(id));
        }

        public virtual void Delete(T entity)
        {
            Delete(_context.Set<T>(), entity);
        }

        protected virtual void Delete(DbSet<T> set, T entity)
        {
            if (entity is IDeletable)
            {
                (entity as IDeletable).IsDeleted = true;
            }
            else
            {
                set.Remove(entity);
            }
        }
    }
}