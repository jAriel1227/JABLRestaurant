using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Application.ViewModel.Tables
{
    public class SaveTablesViewModel
    {
        public int Numberofpeople { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
    }
}
