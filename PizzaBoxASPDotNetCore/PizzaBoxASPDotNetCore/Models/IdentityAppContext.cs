using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PizzaBoxWeb.Models
{
    public class IdentityAppContext :IdentityDbContext<PizzaUserViewModel, Role, int>
    {

        public IdentityAppContext(DbContextOptions<IdentityAppContext> options): base(options)
        {

        }



    }
}
