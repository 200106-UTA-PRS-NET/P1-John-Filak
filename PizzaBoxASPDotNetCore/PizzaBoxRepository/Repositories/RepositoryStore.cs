using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxRepository.Repositories
{
    public class RepositoryStore : IRepositoryStore<PizzaBoxLibrary.Models.Store>
    {
        DBPizzaBoxContext db;
        public RepositoryStore()
        {
            db = new DBPizzaBoxContext();
        }
        public RepositoryStore(DBPizzaBoxContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public void AddStore(PizzaBoxLibrary.Models.Store pizzastore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PizzaBoxLibrary.Models.Store> GetStores()
        {
            throw new NotImplementedException();
        }
    }
}
