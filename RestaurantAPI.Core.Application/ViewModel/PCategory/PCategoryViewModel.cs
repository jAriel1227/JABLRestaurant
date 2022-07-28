using RestauranteAPI.Core.Application.ViewModel.Plates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.ViewModel.PCategory
{
    public class PCategoryViewModel
    {
        public string Name { get; set; }
        public List<PlatesViewModel> PlatesC { get; set; }
    }
}
