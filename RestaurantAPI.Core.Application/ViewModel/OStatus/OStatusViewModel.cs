﻿using RestauranteAPI.Core.Application.ViewModel.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.ViewModel.OStatus
{
    public class OStatusViewModel
    {
        public string Name { get; set; }
        public List<OrdersViewModel> Oders { get; set; }
    }
}
