using RestaurantAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Domain.Entities
{
    public class Oders : AuditableBaseEntity
    {
        public string IdTable { get; set; }
        public int IdPlates { get; set; }
        public bool SubTotal { get; set; }

        public int StateId { get; set; }
        public OdersStatus OdersStatus { get; set; }
        public ICollection<Plates> Plates { get; set; }
    }
}
