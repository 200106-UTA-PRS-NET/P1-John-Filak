﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class StoreViewModel 
    {
        

        public string Storename { get; set; }
        public string StorePassword { get; set; }
        public string Cell { get; set; }
        public string StoreAddress { get; set; }
        public string? PresetSpecial { get; set; }
        public int? PresetPizzaId { get; set; }
        public DateTime? StoreJoinDate { get; set; }


    }
}
