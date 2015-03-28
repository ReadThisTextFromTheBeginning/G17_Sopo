using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Domain.Interfaces
{
    public interface ICommand
    {
        void Execute(Invoice invoice, IUnitOfWork unitOfWork);
    }
}
