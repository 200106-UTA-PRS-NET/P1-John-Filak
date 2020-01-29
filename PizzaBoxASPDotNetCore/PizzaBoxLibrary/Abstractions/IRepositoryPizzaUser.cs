using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxLibrary.Abstractions
{
        public interface IRepositoryPizzaUser<T>
        {
            IEnumerable<T> GetPizzaUser();
            void AddPizzaUser(T pizzauser);

        
    }
}
