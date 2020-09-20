using MvcComEntities;
using MvcComServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcComWeb.Controllers
{
        public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsTable(string search)
        {
            var products = productsService.GetProducts();

            if (!string.IsNullOrEmpty(search))
            {
                //products = products.Where(p => p.Name == search).ToList();

                //or
                products = products.Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower())).ToList();

            }

            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProductsTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productsService.GetProduct(ID);
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productsService.UpdateProduct(product);
            return RedirectToAction("ProductsTable");
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productsService.DeleteProduct(ID);
            return RedirectToAction("ProductsTable");
        }


    }
}