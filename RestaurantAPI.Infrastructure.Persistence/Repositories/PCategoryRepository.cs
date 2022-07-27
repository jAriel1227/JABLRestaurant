using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;
using RestauranteAPI.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class PCategoryRepository : GenericRepository<PlatesCategory>, IPCategoryRepository
    {
        private readonly ApplicationContext _applicationContext;
        public PCategoryRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
