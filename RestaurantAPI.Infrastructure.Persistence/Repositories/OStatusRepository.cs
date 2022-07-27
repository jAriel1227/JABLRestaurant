using RestauranteAPI.Infrastructure.Persistence.Contexts;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class OStatusRepository : GenericRepository<OdersStatus>, IOStatusRepository
    {
        private readonly ApplicationContext _applicationContext;

        public OStatusRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
