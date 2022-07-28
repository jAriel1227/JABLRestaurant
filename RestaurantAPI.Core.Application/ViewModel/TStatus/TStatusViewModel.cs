using RestauranteAPI.Core.Application.ViewModel.Tables;
using System.Collections.Generic;

namespace RestauranteAPI.Core.Application.ViewModel.TStatus
{
    public class TStatusViewModel
    {
        public string Name { get; set; }
        public List<TablesViewModel> Tables { get; set; }
    }
}
