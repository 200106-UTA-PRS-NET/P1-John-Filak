using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            db.PizzaOrder.Add(Mapper.Map(pizzaorder));
            db.SaveChanges();
        }

        public int GetMyOrder(string Username, string Storename)
        {
            var query = (from e in db.PizzaOrder
                         where e.Username.Equals(Username) & e.Storename.Equals(Storename)
                         orderby e.OrderDate descending
                         select e.Orderid).Take(1);

            int orderid = query.FirstOrDefault();
            return orderid; 
        }

        public IEnumerable<PizzaBoxLibrary.Models.PizzaOrder> GetPizzaOrders()
        {
            var query = from e in db.PizzaOrder
                        select Mapper.Map(e);

            return query; 

        }



    }
}
