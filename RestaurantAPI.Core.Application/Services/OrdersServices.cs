﻿using AutoMapper;
using RestauranteAPI.Core.Application.Interfaces.Repository;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.Orders;
using RestauranteAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
