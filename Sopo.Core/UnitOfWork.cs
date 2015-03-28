using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Domain.BaseTypes;
using Sopo.Domain;
using Sopo.Repository;
using Sopo.Domain.Interfaces;

namespace Sopo.Core
{
    public class UnitOfWork<T> : IUnitOfWork //CopyPasted
        where T : class, new()
    {
        protected T _entity;    //not CopyPasted
        protected Log _log;     //not CopyPasted
        private bool _isCommited = false;

        public bool IsCommited
        {
            get
            {
                return _isCommited;
            }
        }

        public UnitOfWork(T entityObj) //not CopyPasted 
        {
            _entity = entityObj;
        }

        public void Commit()
        {
            _log = new Log();
            _log.Date = DateTime.Now;
            _log.Text = "Entity Type " + (typeof(T)).ToString() + " was Commited";
            _isCommited = true;
        }
    }
}
