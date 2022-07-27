using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.ViewModel.Orders
{
    public class OrdersViewModel
    {
        public string IdTable { get; set; }
        public int IdPlates { get; set; }
        public bool SubTotal { get; set; }
        public int StateId { get; set; }
    }
}
