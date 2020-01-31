using PizzaBoxLibrary.Abstractions;
using PizzaBoxRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBoxRepository.Repositories
{
    public class RepositoryPizzaUser : IRepositoryPizzaUser<PizzaBoxLibrary.Models.PizzaUser>
    {

        DBPizzaBoxContext db;
        public RepositoryPizzaUser()
        {
            db = new DBPizzaBoxContext();
        }
        public RepositoryPizzaUser(DBPizzaBoxContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        //LOGIN
        public int ValidLogin(string UID, string PW)
        {
            if(db.PizzaUser.Any(e => e.Username == UID & e.UserPassword == PW)){
                return 1; 
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
                return 0; 
            }
        }


        //CREATE 
        public void AddPizzaUser(PizzaBoxLibrary.Models.PizzaUser pizzauser)
        {
            if (db.PizzaUser.Any(e => e.Username == pizzauser.Username) || pizzauser.Username == null)
            {
                Console.WriteLine($"This username : {pizzauser.Username} already exists. Please choose another");
                return;
            }

            db.PizzaUser.Add(Mapper.Map(pizzauser));
            db.SaveChanges();

        }

        public IEnumerable<PizzaBoxLibrary.Models.PizzaUser> GetPizzaUser()
        {
            var query = from e in db.PizzaUser
                        select Mapper.Map(e);

            return query;
        }


    }//class
}//namespace
