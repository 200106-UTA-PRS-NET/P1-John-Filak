using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Models
{
    public partial class PizzaOrder
    {
        public int Orderid { get; set; }
        public string Username { get; set; }
        public string Storename { get; set; }
        public decimal Cost { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
