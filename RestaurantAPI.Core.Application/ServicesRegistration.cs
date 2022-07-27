using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.Services;

namespace RestauranteAPI.Core.Application
{
    public static class ServicesRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service) 
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            service.AddTransient(typeof(IGenericServices<,,>), typeof(GenericServices<,,>));
            service.AddTransient<IIngredientsServices, IngredientsServices>();
            service.AddTransient<IOrdersServices, OrdersServices>();
            service.AddTransient<IOStatusServices, OStatusServices>();
            #endregion

        }
    }
}
