﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Страница описания приложения.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов.";

            return View();
        }

        public ActionResult Price()
        {
            return View();
        }

        public ActionResult RulesAndPayment()
        {
            return View();
        }

        public ActionResult Relax()
        {
            return View();
        }

        public ActionResult Example()
        {
            return View();
        }
    }
}