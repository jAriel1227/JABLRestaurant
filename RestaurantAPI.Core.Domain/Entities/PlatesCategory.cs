using RestaurantAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Domain.Entities
{
    public class PlatesCategory : AuditableBaseEntity
    {
        public string Name { get; set; }
        public ICollection<Plates> PlatesC { get; set; }
    }
}
