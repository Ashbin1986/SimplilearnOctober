using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceWebAPI.Controllers
{
    public class ECommerceAPIController : Controller
    {
        // GET: ECommerceAPI
        public ActionResult Index()
        {
            return View();
        }

        // GET: ECommerceAPI/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ECommerceAPI/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ECommerceAPI/Create
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

        // GET: ECommerceAPI/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ECommerceAPI/Edit/5
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

        // GET: ECommerceAPI/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ECommerceAPI/Delete/5
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
