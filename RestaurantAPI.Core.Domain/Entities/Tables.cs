using RestaurantAPI.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Core.Domain.Entities
{
    public class Tables : AuditableBaseEntity
    {
        public int Numberofpeople { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
        public TablesStatus TablesStatus { get; set; }
    }
}
