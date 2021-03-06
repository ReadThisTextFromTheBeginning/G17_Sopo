﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sopo.Repository;
using Sopo.Domain;
using Sopo.Domain.Interfaces;
namespace Sopo.Core.Services
{
    public sealed class PictureService : ServiceBase<Sopo.Domain.Picture, PictureRepository>
    {
        public PictureService(IUnitOfWork contextObj, PictureRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
