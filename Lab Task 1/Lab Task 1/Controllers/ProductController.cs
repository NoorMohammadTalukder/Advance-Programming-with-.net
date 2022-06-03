using Lab_Task_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Task_1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //Product p1 = new Product();
            List<Product> products = new List<Product>();
            for (int i = 0; i <= 10; i++)
            {
                products.Add(new Product()
                {
                    Id=i+1,
                    Name="product"+(i+1),
                    Description="This is a product"
                });;
                
            }
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}