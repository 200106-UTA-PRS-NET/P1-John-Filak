using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class PizzaViewModel
    {
        public int Pid { get; set; }
        public int OrderId { get; set; }
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


    }
}
