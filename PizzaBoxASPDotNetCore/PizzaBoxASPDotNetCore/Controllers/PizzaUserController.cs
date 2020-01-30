using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxLibrary.Abstractions;
using PizzaBoxLibrary.Models;
using PizzaBoxWeb.Models;

namespace PizzaBoxWeb.Controllers
{
    public class PizzaUserController : Controller
    {
        public IRepositoryPizzaUser<PizzaBoxLibrary.Models.PizzaUser> userrepo; 
        public PizzaUserController(IRepositoryPizzaUser<PizzaBoxLibrary.Models.PizzaUser> PizzaUserRepo)
        {
            userrepo = PizzaUserRepo;
        }

        // GET: PizzaUser
        public ActionResult Index(){
            IEnumerable<PizzaBoxLibrary.Models.PizzaUser> pizzausers = userrepo.GetPizzaUser();
            IEnumerable<PizzaUserViewModel> viewModels = pizzausers.Select( x => new PizzaUserViewModel
            {
                Username = x.Username,
                FirstName = x.FirstName,
                LastName = x.LastName
            });
            return View(viewModels);
        }


        

        
        // GET: PizzaUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaUser/Create
        public ActionResult Create()
        {
            return View("/Home/SignUp");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(PizzaUserViewModel pizzaUser)
        {
            try
            {
                // TODO: Add insert logic here
                string UsernameInput = pizzaUser.Username;
                string UserPasswordInput = pizzaUser.UserPassword;

                int response = userrepo.ValidLogin(UsernameInput, UserPasswordInput);

                if(response == 1)
                {
                    Console.WriteLine("WELCOME");
                    TempData["Login"] = UsernameInput;

                    return RedirectToAction("LoggedIn", "Home");
                }
                else
                {
                    Console.WriteLine("Denied");
                  
                    return RedirectToAction("Login","Home");
                }


                
            }
            catch
            {
                return View();
            }
        }


        // POST: PizzaUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PizzaUserViewModel pizzaUser)
        {
            try
            {

                // TODO: Add insert logic here
                PizzaBoxLibrary.Models.PizzaUser newUser = new PizzaBoxLibrary.Models.PizzaUser()
                {
                    Username = pizzaUser.Username,
                    UserPassword = pizzaUser.UserPassword,
                    FirstName = pizzaUser.FirstName,
                    LastName = pizzaUser.LastName,
                    Cell = pizzaUser.Cell, 
                    UserAddress = pizzaUser.UserAddress,
                    Email = pizzaUser.Email
                };

                userrepo.AddPizzaUser(newUser);

                return RedirectToAction("Login", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}