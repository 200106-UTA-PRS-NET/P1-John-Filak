using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxRepository.Repositories
{
    public class RepositoryPizzaOrder : IRepositoryPizzaOrder<PizzaBoxLibrary.Models.PizzaOrder>
    {

        DBPizzaBoxContext db;
        public RepositoryPizzaOrder()
        {
            db = new DBPizzaBoxContext();
        }
        public RepositoryPizzaOrder(DBPizzaBoxContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddPizzaOrder(PizzaBoxLibrary.Models.PizzaOrder pizzaorder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PizzaBoxLibrary.Models.PizzaOrder> GetPizzaOrders()
        {
            throw new NotImplementedException();
        }
    }
}
