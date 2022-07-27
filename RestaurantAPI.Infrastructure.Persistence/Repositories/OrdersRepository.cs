using RestauranteAPI.Infrastructure.Persistence.Contexts;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class OrdersRepository : GenericRepository<Oders>, IOrdersRepository
    {
        private readonly ApplicationContext _applicationContext;

        public OrdersRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
    }
}
