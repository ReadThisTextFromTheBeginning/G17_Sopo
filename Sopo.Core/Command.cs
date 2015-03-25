using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Interfaces;

namespace Sopo.Core
{
   public class Command<T> : ICommand where T : class, new() //CopyPasted
    {
         T entity;
         protected   IUnitOfWork uow;

         public Command(IUnitOfWork uowObj, T entityObj)
         {
             uow = uowObj;
             entity = entityObj;
         }  //not CopyPasted

        public void Execute(Invoice invoice, IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }
    }
}
