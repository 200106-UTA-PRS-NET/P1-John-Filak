using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxRepository.Repositories
{
    public class RepositoryPizza : IRepositoryPizza<PizzaBoxLibrary.Models.Pizza>
    {

        DBPizzaBoxContext db;
        public RepositoryPizza()
        {
            db = new DBPizzaBoxContext();
        }
        public RepositoryPizza(DBPizzaBoxContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddPizza(PizzaBoxLibrary.Models.Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PizzaBoxLibrary.Models.Pizza> GetPizzas()
        {
            throw new NotImplementedException();
        }
    }
}
