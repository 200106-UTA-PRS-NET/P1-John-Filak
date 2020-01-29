using System;
using System.Collections.Generic;

namespace PizzaBoxRepository.Models

{
    public partial class PizzaUser
    {
        public PizzaUser()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cell { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public DateTime? UserJoinDate { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
