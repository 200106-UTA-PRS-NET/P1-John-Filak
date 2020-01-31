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

        public float ComputePrice(int numToppings)
        {
            float price;

            float baseCost = 10.00f;

            float costMultiplier = 1.0f;

            switch (this.Crust)
            {
                case "Deep Dish":
                    costMultiplier += 0.2f;
                    break;
                case "Thin":
                    costMultiplier += 0.1f;
                    break;
                case "Stuffed":
                    costMultiplier += 0.3f;
                    break;

            }// crust


            switch (this.Size)
            {
                case "Medium":
                    costMultiplier += 0.1f;
                    break;
                case "Large":
                    costMultiplier += 0.2f;
                    break;
                case "X-Large":
                    costMultiplier += 0.3f;
                    break;
            }//size

            //each topic is one dollar
            baseCost += (float)numToppings;


            price = costMultiplier * baseCost;
            return price;

        }//compute price 
    }
}
