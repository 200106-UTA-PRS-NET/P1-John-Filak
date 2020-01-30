using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


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
            db.Store.Add(Mapper.Map(pizzastore));
            db.SaveChanges();
            
        }


        public IEnumerable<PizzaBoxLibrary.Models.Store> GetStores()
        {
            
                var query = from e in db.Store
                            select Mapper.Map(e);

                return query;
            
        }
    }
}
