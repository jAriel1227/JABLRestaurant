using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Infrastructure.Persistence.Contexts;
using RestauranteAPI.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RestauranteAPI.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {

        public static void AddPersistenceInfrastructure(this IServiceCollection service, IConfiguration configuration) {

            #region Contexts

            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                service.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("RestaurantAPIMemory"));
            }
            else
            {
                service.AddDbContext<ApplicationContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("RestaurantAPIConnection"), 
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }

            #endregion

            #region Repository

            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IIngredientsRepository, IngredientsRepository>();
            service.AddTransient<IOrdersRepository, OrdersRepository>();
            service.AddTransient<IOStatusRepository, OStatusRepository>();
            service.AddTransient<IPlatesRepository, PlatesRepository>();
            service.AddTransient<IPCategoryRepository, PCategoryRepository>();
            service.AddTransient<ITablesRepository, TablesRepository>();
            service.AddTransient<ITStatusRepository, TStatusRepository>();

            #endregion
        }

    }
}
