using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Models
{
    public partial class Store
    {
        public string Storename { get; set; }
        public string StorePassword { get; set; }
        public string Cell { get; set; }
        public string StoreAddress { get; set; }
        public string? PresetSpecial { get; set; }
        public int? PresetPizzaId { get; set; }
        public DateTime? StoreJoinDate { get; set; }


        /*
        public virtual Pizza PresetPizza { get; set; }
        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
        public virtual ICollection<PizzaUser> PizzaUser { get; set; }
        */

    }//class
}//namespace
