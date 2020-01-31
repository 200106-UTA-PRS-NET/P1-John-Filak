using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class PizzaUserViewModel : IdentityUser<int>
    {
        
        [StringLength(maximumLength:20)]
        [Required]
        public string Username { get; set; }
        [StringLength(maximumLength: 20)]
        [Required]
        public string UserPassword { get; set; }
        [StringLength(maximumLength: 20)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(maximumLength: 20)]
        [Required]
        public string LastName { get; set; }
       

        [Phone]
        public string Cell { get; set; }
        [Required]
        public string UserAddress { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }


    }
}
