using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            db.Pizza.Add(Mapper.Map(pizza));
            db.SaveChanges();
        }

        public void DeletePizzas(int oid)
        {
            var query = from e in db.Pizza
                        where e.Orderid == oid
                        select e;
            foreach (var p in query)
            {
                db.Pizza.Remove(p);
            }
            db.SaveChanges();
        }

        public IEnumerable<PizzaBoxLibrary.Models.Pizza> GetPizzas()
        {
            var query = from e in db.Pizza
                        select Mapper.Map(e);

            return query;
        }

        public IEnumerable<PizzaBoxLibrary.Models.Pizza> GetPizzasByOrderId(int oid)
        {
            var query = from e in db.Pizza
                        where e.Orderid == oid
                        select Mapper.Map(e);
            return query;

        }
    }
}
