using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Abstractions
{
    public interface IRepositoryStore<T>
    {
        IEnumerable<T> GetStores();

        void AddStore(T pizzastore);

        int ValidLogin(string storename, string password);


    }
}
