using RestauranteAPI.Core.Application.ViewModel.Orders;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Interfaces.Services
{
     public interface IOrdersServices : IGenericServices<SaveOrdersViewModel, OrdersViewModel, Oders>
     {

     }
}
