using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxLibrary.Abstractions;
using PizzaBoxWeb.Models;

namespace PizzaBoxWeb.Controllers
{

    public class PizzaController : Controller
    {

        public IRepositoryPizza<PizzaBoxLibrary.Models.Pizza> pizzarepo;
        public PizzaController(IRepositoryPizza<PizzaBoxLibrary.Models.Pizza> PizzaRepo)
        {
            pizzarepo = PizzaRepo;
        }



        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pizza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PizzaViewModel pizza)
        {


                TempData["Total"] = int.Parse(TempData["Total"].ToString()) + (int)pizza.Cost; 
                TempData.Keep("Username");
                TempData.Keep("Store");
                TempData.Keep("OrderId");
            

            try
            {
                // TODO: Add insert logic here
                PizzaBoxLibrary.Models.Pizza newPizza = new PizzaBoxLibrary.Models.Pizza()
                {
                    OrderId = pizza.OrderId, 
                    Cheese = 1, 
                    Sauce = 1, 
                    Cost = pizza.Cost,
                    Crust = pizza.Crust,
                    Size = pizza.Size, 
                    ExtraCheese = pizza.ExtraCheese, 
                    Bacon = pizza.Bacon, 
                    Pepperoni = pizza.Pepperoni, 
                    Mozzerella = pizza.Mozzerella, 
                    Sausage = pizza.Sausage,
                    Pineapple = pizza.Pineapple,
                    Onion = pizza.Onion, 
                    Chicken = pizza.Chicken, 
                    Pepper = pizza.Pepper
                };

                pizzarepo.AddPizza(newPizza);

                IEnumerable<PizzaBoxLibrary.Models.Pizza> currentpizzas = pizzarepo.GetPizzasByOrderId(int.Parse(TempData["OrderId"].ToString()));
                IEnumerable<PizzaViewModel> pizzas = currentpizzas.Select(x => new PizzaViewModel
                {
                    Pid = x.Pid,
                    OrderId = x.OrderId,
                    Cheese = x.Cheese,
                    Sauce= x.Sauce,
                    Cost = x.Cost,
                    Crust = x.Crust, 
                    Size = x.Size,
                    ExtraCheese = x.ExtraCheese,
                    Bacon = x.Bacon,
                    Pepperoni = x.Pepperoni,
                    Mozzerella = x.Mozzerella,
                    Sausage = x.Sausage,
                    Pineapple = x.Pineapple,
                    Onion = x.Onion,
                    Chicken = x.Chicken,
                    Pepper = x.Pepper

                });

                return View( pizzas);
           
                return RedirectToAction("PreOrder", "PizzaOrder", pizzas);
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
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

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
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