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
    public sealed class RatingService : ServiceBase<Sopo.Domain.Rating, RatingRepository>
    {
        public RatingService(IUnitOfWork contextObj, RatingRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {

        }
    }
}
