using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Abstractions
{
    public interface IRepositoryPizzaOrder<T>
    {
        IEnumerable<T> GetPizzaOrders();

        void AddPizzaOrder(T pizzaorder);
    }
}
