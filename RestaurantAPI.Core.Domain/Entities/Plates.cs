using RestaurantAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Domain.Entities
{
    public class Plates : AuditableBaseEntity
    {
        public string PlateName { get; set; }
        public string PlatePrice { get; set; }
        public int givePeple { get; set; }
        public int IdCategory { get; set; }
        public int IdOrders { get; set; }

        public Plates PlatesIngredients { get; set; }
        public Oders Oders { get; set; }
        public PlatesCategory PlatesCategory  { get; set; }
        public ICollection<Ingredients> Ingredients { get; set; }

    }
}
