﻿using Sopo.Domain;
using Sopo.Interfaces;
using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Core.Services
{
    public sealed class CountryService : ServiceBase<Country, CountryRepository>
    {
        public CountryService(IUnitOfWork contextObj, CountryRepository repositoryObj)
            : base(contextObj, repositoryObj)
        {
        }
    }
}
