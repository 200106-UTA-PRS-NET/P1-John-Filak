using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class PizzaOrderViewModel
    {

        public int Orderid { get; set; }
        public string Username { get; set; }
        public string Storename { get; set; }
        public decimal Cost { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
