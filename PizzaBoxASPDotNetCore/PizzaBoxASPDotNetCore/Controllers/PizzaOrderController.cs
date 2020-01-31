using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxLibrary.Abstractions;
using PizzaBoxWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBoxWeb.Controllers
{
    public class PizzaOrderController : Controller
    {

        public IRepositoryPizzaOrder<PizzaBoxLibrary.Models.PizzaOrder> orderrepo;
        public PizzaOrderController(IRepositoryPizzaOrder<PizzaBoxLibrary.Models.PizzaOrder> PizzaOrderRepo, IRepositoryStore<PizzaBoxLibrary.Models.Store> StoreRepo)
        {
            orderrepo = PizzaOrderRepo;
            storerepo = StoreRepo;
        }


        public IRepositoryStore<PizzaBoxLibrary.Models.Store> storerepo;


        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: Order/Create
        public ActionResult Create()
        {
            IEnumerable<PizzaBoxLibrary.Models.Store> storesX = storerepo.GetStores();
            IEnumerable<StoreViewModel> stores = storesX.Select(x => new StoreViewModel
            {
                Storename = x.Storename
            });


            ViewData["Stores"] = stores;
            return View();
        }


        public ActionResult StoreOrders()
        {
            TempData.Keep("Login");

            IEnumerable<PizzaBoxLibrary.Models.PizzaOrder> orders = orderrepo.GetOrdersByStore(TempData["Login"].ToString());
            IEnumerable<PizzaOrderViewModel> StoreOrders = orders.Select(x => new PizzaOrderViewModel
            {
                Orderid = x.Orderid,
                Username = x.Username,
                Cost = x.Cost,
                OrderDate = x.OrderDate

            });


            return View(StoreOrders);


           
        }


        public ActionResult DeleteUserOrder()
        {
            TempData["Login"] = TempData["Username"].ToString();
            orderrepo.DeleteOrder(int.Parse(TempData["Orderid"].ToString()));

            return RedirectToAction("LoggedIn", "Home");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Start(PizzaOrderViewModel order)
        {
            PizzaBoxLibrary.Models.PizzaOrder newOrder = new PizzaBoxLibrary.Models.PizzaOrder()
            {
                Username = order.Username,
                Storename = order.Storename,
                Cost = new decimal(0.00)

            };

            orderrepo.AddPizzaOrder(newOrder);

           // orderrepo.

                string Username = order.Username;
                string Storename = order.Storename;

            //GET LAST ORDER NUMBER AND PASS IT SO PIZZAS WILL HAVE IT 
                TempData["Orderid"] = orderrepo.GetMyOrder(Username, Storename);
                TempData["Username"] = Username;
                TempData["Store"] = Storename;
                TempData["Total"] = 0; 
                

            return View();
        }

        public ActionResult MorePies()
        {
            TempData.Keep("Username");
            TempData.Keep("Store");
            TempData.Keep("Orderid");
            TempData.Keep("Total");

            return View("Start");
        }


        public ActionResult PreOrder(IEnumerable<PizzaBoxWeb.Models.PizzaViewModel> pizzas)
        {
            TempData.Keep("Username");
            TempData.Keep("Store");
            TempData.Keep("Orderid");
            TempData.Keep("Total");
            
            return View(pizzas);
        }



        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Submit()
        {
            TempData.Keep("Username");
            TempData.Keep("Store");
            TempData.Keep("Orderid");
            TempData.Keep("Total");

            //update order cost and order date 
            orderrepo.UpdateOrder(int.Parse(TempData["Orderid"].ToString()), decimal.Parse(TempData["Total"].ToString()));
            TempData["Login"] = TempData["Username"];

            return RedirectToAction("LoggedIn","Home");
        }

        public ActionResult UserHistory()
        {
            TempData.Keep("Login");
            IEnumerable<PizzaBoxLibrary.Models.PizzaOrder> orders = orderrepo.GetOrdersByUser(TempData["Login"].ToString());
            IEnumerable<PizzaOrderViewModel> personalOrders = orders.Select(x => new PizzaOrderViewModel
            {
                Orderid = x.Orderid,
                Storename = x.Storename,
                Cost = x.Cost,
                OrderDate = x.OrderDate

            }) ;


            return View(personalOrders);
        }


        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
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

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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