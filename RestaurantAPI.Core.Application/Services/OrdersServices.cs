using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.Orders;
using RestauranteAPI.Core.Domain.Entities;

namespace RestauranteAPI.Core.Application.Services
{
    public class OrdersServices : GenericServices<SaveOrdersViewModel, OrdersViewModel, Oders>, IOrdersServices
    {
        private readonly IOrdersRepository _ordersRepository;
        private IMapper _mapper;
        public OrdersServices(IOrdersRepository ordersRepository, IMapper mapper) : base(ordersRepository, mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }
    }
}
