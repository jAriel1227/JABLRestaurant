using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;
using RestauranteAPI.Infrastructure.Persistence.Contexts;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class TablesRepository : GenericRepository<Tables>, ITablesRepository
    {
        private readonly ApplicationContext _applicationContexts;
        public TablesRepository(ApplicationContext applicationContexts) : base(applicationContexts)
        {
            _applicationContexts = applicationContexts;
        }
    }
}
