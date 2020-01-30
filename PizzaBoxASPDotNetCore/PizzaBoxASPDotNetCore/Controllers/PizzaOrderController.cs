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




        // GET: Order


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






        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Start(PizzaOrderViewModel order)
        {
                string Username = order.Username;
                string Storename = order.Storename;
                TempData["Username"] = Username;
                TempData["Store"] = Storename;

            return View();
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