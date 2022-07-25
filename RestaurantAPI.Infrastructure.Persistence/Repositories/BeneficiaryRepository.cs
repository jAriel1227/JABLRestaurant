﻿using RestaurantAPI.Core.Application.Interfaces.Repository;
using RestaurantAPI.Core.Domain.Entities;
using RestaurantAPI.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Infrastructure.Persistence.Repositories
{
    public class BeneficiaryRepository: GenericRepository<Beneficiary>, IBeneficiaryRepository
    {
        private readonly ApplicationContext _applicationContext;

        public BeneficiaryRepository(ApplicationContext applicationContext): base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
