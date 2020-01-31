using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Abstractions
{
    public interface IRepositoryPizza<T>
    {
        IEnumerable<T> GetPizzas();
        void AddPizza(T pizza);

        IEnumerable<T> GetPizzasByOrderId(int oid);


    }
}
