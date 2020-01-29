using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Models
{
    public partial class PizzaUser
    {
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cell { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public DateTime? UserJoinDate { get; set; }


    }//class
}//namespace
