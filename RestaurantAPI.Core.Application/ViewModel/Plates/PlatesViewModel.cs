using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.ViewModel.Plates
{
    public class PlatesViewModel
    {
        public string PlateName { get; set; }
        public string PlatePrice { get; set; }
        public int givePeple { get; set; }
        public int IdCategory { get; set; }
        public int IdOrders { get; set; }
    }
}
