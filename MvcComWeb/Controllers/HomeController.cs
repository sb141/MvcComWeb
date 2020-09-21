﻿using MvcComServices;
using MvcComWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcComWeb.Controllers
{
    public class HomeController : Controller
    {
        CategoriesServices categoryService = new CategoriesServices();
        public ActionResult Index()
        {
            HomeViewModels model = new HomeViewModels();
            model.Categories = categoryService.GetCategory();
            return View(model);
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