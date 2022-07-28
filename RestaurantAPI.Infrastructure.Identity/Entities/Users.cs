using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.Identity.Entities
{
    public class Users : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Documents { get; set; }
    }
}
