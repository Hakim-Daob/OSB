using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSBOnlineBank.Controllers
{
    public class BankUserController : Controller
    {
        // GET: BankUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: BankUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankUser/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
