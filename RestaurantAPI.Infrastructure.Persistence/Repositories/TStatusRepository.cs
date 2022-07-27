using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Domain.Entities;
using RestauranteAPI.Infrastructure.Persistence.Contexts;

namespace RestauranteAPI.Infrastructure.Persistence.Repositories
{
    public class TStatusRepository : GenericRepository<TablesStatus>, ITStatusRepository
    {
        public readonly ApplicationContext _applicationContexts;

        public TStatusRepository(ApplicationContext applicationContexts) : base(applicationContexts)
        {
            _applicationContexts = applicationContexts;
        }
    }
}
