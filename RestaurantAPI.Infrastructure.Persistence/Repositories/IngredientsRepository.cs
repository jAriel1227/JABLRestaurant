using RestauranteAPI.Infrastructure.Persistence.Contexts;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class IngredientsRepository : GenericRepository<Ingredients>, IIngredientsRepository
    {
        private readonly ApplicationContext _applicationContext;

        public IngredientsRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
             _applicationContext = applicationContext;
        }
    }
}

