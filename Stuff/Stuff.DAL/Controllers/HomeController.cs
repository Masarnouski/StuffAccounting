﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Stuff.DAL.Models;
using Stuff.DAL.Repositories;

namespace Stuff.DAL.Controllers
{
    public class HomeController : Controller
    {   
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            using (EmployeeRepository repo = new EmployeeRepository())
            {
                repo.Update(employee);
                return RedirectToAction("Read");
            }
        }
        public ActionResult Read()
        {
            using (EmployeeRepository repo = new EmployeeRepository())
            {
                return View(repo.Read());
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}