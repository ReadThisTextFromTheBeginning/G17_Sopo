using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Interfaces
{
    public interface IUnitOfWork
    {
        void MarkDirty(object entity);

        void MarkNew(object entity);

        void MarkDeleted(object entity);

        void Commit();

        void Rollback();
    }
}
