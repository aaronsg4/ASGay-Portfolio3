using ASGay_Portfolio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ASGay_Portfolio.Areas.FinancialPlanner.Controllers
{
    public class HomeController : Controller
    {
        // GET: FinancialPlanner/Home
        public ActionResult Index()
        {
         
            //var xMe = new AccountController().LogOff("FinancialPlanner");
            return View();
        }

        // GET: FinancialPlanner/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FinancialPlanner/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialPlanner/Home/Create
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

        // GET: FinancialPlanner/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FinancialPlanner/Home/Edit/5
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

        // GET: FinancialPlanner/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FinancialPlanner/Home/Delete/5
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
