using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Abstractions
{
    public interface IRepositoryPizzaOrder<T>
    {
        IEnumerable<T> GetPizzaOrders();

        void AddPizzaOrder(T pizzaorder);

        int GetMyOrder(string Username, string Storename);

        void UpdateOrder(int orderid, decimal cost);

        IEnumerable<T> GetOrdersByUser(string username);

        IEnumerable<T> GetOrdersByStore(string storename);

        void DeleteOrder(int orderid); 
    }
}
