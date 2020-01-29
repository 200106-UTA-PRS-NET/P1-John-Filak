using System;
using System.Collections.Generic;

namespace PizzaBoxRepository.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            Store = new HashSet<Store>();
        }

        public int Pid { get; set; }
        public int Orderid { get; set; }
        public decimal Cost { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }
        public int? Cheese { get; set; }
        public int? Sauce { get; set; }
        public int ExtraCheese { get; set; }
        public int Bacon { get; set; }
        public int Pepperoni { get; set; }
        public int Mozzerella { get; set; }
        public int Sausage { get; set; }
        public int Pineapple { get; set; }
        public int Onion { get; set; }
        public int Chicken { get; set; }
        public int Pepper { get; set; }

        public virtual PizzaOrder Order { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
