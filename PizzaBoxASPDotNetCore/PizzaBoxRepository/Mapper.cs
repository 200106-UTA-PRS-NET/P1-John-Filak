using System;
using System.Collections.Generic;
using System.Text;
using PizzaBoxLibrary;
using System.Linq;

namespace PizzaBoxRepository
{
    public static class Mapper
    {
        public static PizzaBoxLibrary.Models.PizzaUser Map(PizzaBoxRepository.Models.PizzaUser pizzauser)
        {
            return new PizzaBoxLibrary.Models.PizzaUser()
            {
                Username = pizzauser.Username,
                UserPassword = pizzauser.UserPassword,
                FirstName = pizzauser.FirstName,
                LastName = pizzauser.LastName,
                Cell = pizzauser.Cell,
                UserAddress = pizzauser.UserAddress,
                Email = pizzauser.Email,
                UserJoinDate = pizzauser.UserJoinDate,

            };
        }


        public static PizzaBoxRepository.Models.PizzaUser Map(PizzaBoxLibrary.Models.PizzaUser pizzauser)
        {
            return new PizzaBoxRepository.Models.PizzaUser()
            {
                Username = pizzauser.Username,
                UserPassword = pizzauser.UserPassword,
                FirstName = pizzauser.FirstName,
                LastName = pizzauser.LastName,
                Cell = pizzauser.Cell,
                UserAddress = pizzauser.UserAddress,
                Email = pizzauser.Email,
                UserJoinDate = pizzauser.UserJoinDate,

            };
        }

        #region store


        public static PizzaBoxLibrary.Models.Store Map(PizzaBoxRepository.Models.Store pizzastore)
        {
            return new PizzaBoxLibrary.Models.Store()
            {
                Storename = pizzastore.Storename,
                StorePassword = pizzastore.StorePassword,
                Cell = pizzastore.Cell,
                StoreAddress = pizzastore.StoreAddress,
                PresetSpecial = pizzastore.PresetSpecial,
                PresetPizzaId = pizzastore.PresetPizzaId,
                StoreJoinDate = pizzastore.StoreJoinDate
            };
        }

        public static PizzaBoxRepository.Models.Store Map(PizzaBoxLibrary.Models.Store pizzastore)
        {
            return new PizzaBoxRepository.Models.Store()
            {
                Storename = pizzastore.Storename,
                StorePassword = pizzastore.StorePassword,
                Cell = pizzastore.Cell,
                StoreAddress = pizzastore.StoreAddress,
                PresetSpecial = pizzastore.PresetSpecial,
                PresetPizzaId = pizzastore.PresetPizzaId,
                StoreJoinDate = pizzastore.StoreJoinDate
            };
        }

        #endregion


        public static PizzaBoxLibrary.Models.PizzaOrder Map(PizzaBoxRepository.Models.PizzaOrder pizzaorder) 
        {
            return new PizzaBoxLibrary.Models.PizzaOrder()
            {
                Orderid = pizzaorder.Orderid,
                Username = pizzaorder.Username,
                Storename = pizzaorder.Storename,
                Cost = pizzaorder.Cost,
                OrderDate = pizzaorder.OrderDate

            };
        }

        public static PizzaBoxRepository.Models.PizzaOrder Map(PizzaBoxLibrary.Models.PizzaOrder pizzaorder)
        {
            return new PizzaBoxRepository.Models.PizzaOrder()
            {
                Orderid = pizzaorder.Orderid,
                Username = pizzaorder.Username,
                Storename = pizzaorder.Storename,
                Cost = pizzaorder.Cost,
                OrderDate = pizzaorder.OrderDate

            };
        }


        public static PizzaBoxLibrary.Models.Pizza Map(PizzaBoxRepository.Models.Pizza pizza)
        {
            return new PizzaBoxLibrary.Models.Pizza()
            {
                OrderId = pizza.Orderid,
                Cost = pizza.Cost,
                Crust = pizza.Crust,
                Size = pizza.Size,
                ExtraCheese = pizza.ExtraCheese,
                Bacon = pizza.Bacon,
                Pepperoni = pizza.Pepperoni,
                Mozzerella = pizza.Mozzerella,
                Sausage = pizza.Sausage,
                Pineapple = pizza.Pineapple,
                Onion = pizza.Onion,
                Chicken = pizza.Chicken,
                Pepper = pizza.Pepper
            };
        }

        public static PizzaBoxRepository.Models.Pizza Map(PizzaBoxLibrary.Models.Pizza pizza)
        {
            return new PizzaBoxRepository.Models.Pizza()
            {
                Orderid = pizza.OrderId,
                Cost = pizza.Cost,
                Crust = pizza.Crust,
                Size = pizza.Size,
                ExtraCheese = pizza.ExtraCheese,
                Bacon = pizza.Bacon,
                Pepperoni = pizza.Pepperoni,
                Mozzerella = pizza.Mozzerella,
                Sausage = pizza.Sausage,
                Pineapple = pizza.Pineapple,
                Onion = pizza.Onion,
                Chicken = pizza.Chicken,
                Pepper = pizza.Pepper
            };
        }


    }//class
}//namespace
