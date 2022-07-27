using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;
using RestauranteAPI.Infrastructure.Persistence.Contexts;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class PlatesRepository : GenericRepository<Plates>, IPlatesRepository
    {
        private readonly ApplicationContext _applicationContext;
        public PlatesRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
