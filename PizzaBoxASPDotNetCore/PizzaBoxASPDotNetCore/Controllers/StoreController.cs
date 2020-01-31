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
    public class StoreController : Controller
    {
        // GET: Store

        public IRepositoryStore<PizzaBoxLibrary.Models.Store> storerepo;
        public StoreController(IRepositoryStore<PizzaBoxLibrary.Models.Store> StoreRepo)
        {
            storerepo = StoreRepo;
        }


        
        public ActionResult Index()
        {
            IEnumerable<PizzaBoxLibrary.Models.Store> stores = storerepo.GetStores();
            IEnumerable<StoreViewModel> viewModels = stores.Select(x => new StoreViewModel
            {
                Storename = x.Storename,
                StoreAddress = x.StoreAddress,
                Cell = x.Cell
            });
            return View(viewModels);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginAttempt(StoreViewModel store)
        {
            try
            {
                string StorenameInput = store.Storename ;
                string StorePasswordInput = store.StorePassword;

                int response = storerepo.ValidLogin(StorenameInput, StorePasswordInput);

                if (response == 1)
                {
                    Console.WriteLine("WELCOME");
                    TempData["Login"] = StorenameInput;

                    return View("Home");
                }
                else
                {
                    Console.WriteLine("Denied");

                    return RedirectToAction("Login", "Store");
                }



            }
            catch
            {
                return View();
            }
        }

        public ActionResult BackToHome()
        {
            TempData.Keep("Login");
            return View("Home");
        }

        public ActionResult Login()
        {
            
            return View();
        }


        // GET: Store/Details/
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create
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

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Store/Edit/5
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

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
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