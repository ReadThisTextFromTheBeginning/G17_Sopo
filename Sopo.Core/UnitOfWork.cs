using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Interfaces;
using Sopo.Domain.BaseTypes;
using Sopo.Domain;
using Sopo.Repository;

namespace Sopo.Core
{
    public class UnitOfWork<T> : IUnitOfWork //CopyPasted
        where T : class, new()
    {
        protected T _entity;    //not CopyPasted
        protected Log _log;     //not CopyPasted

        public UnitOfWork(T entityObj) //not CopyPasted 
        {
            _entity = entityObj;
            this.MarkDirty(_entity);
        }

        public void MarkDirty(object entity)
        {
            throw new NotImplementedException();
        }

        public void MarkNew(object entity)
        {
            throw new NotImplementedException();
        }

        public void MarkDeleted(object entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            this.MarkNew(_entity);
            throw new NotImplementedException();
            //_log = new Log();
            //_log.Date = DateTime.Now;
            //_log.Text = "Entity Type " + (typeof(T)).ToString() + " was Commited";
        }

        public void Rollback()
        {
            this.MarkDeleted(_entity);
            throw new NotImplementedException();
        }
    }
}
