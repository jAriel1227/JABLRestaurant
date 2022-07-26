using RestaurantAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Domain.Entities
{
    public class Ingredients : AuditableBaseEntity
    {
        public string IngredientName { get; set; }
        public int PlateId { get; set; }
        public Plates Plates { get; set; }
    }
}
