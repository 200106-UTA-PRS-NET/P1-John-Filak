using System;
using System.Collections.Generic;

namespace PizzaBoxRepository.Models

{
    public partial class PizzaOrder
    {
        public PizzaOrder()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int Orderid { get; set; }
        public string Username { get; set; }
        public string Storename { get; set; }
        public decimal Cost { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Store StorenameNavigation { get; set; }
        public virtual PizzaUser UsernameNavigation { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
