using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_Task_1.Models;

namespace Lab_Task_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student st)
        {
            var date = st.Dob;
            var presentDate = DateTime.Now;
            var age = presentDate - date;
            var ageDays = age.TotalDays;

            //// if (ModelState.IsValid && ageDays >= 6570)
            {

                return RedirectToAction("Index");
                // }
                // if (ageDays >= 0)
                // {
                //    TempData["message"] = "Aage must be greater than 18";
                //   return View(st);
                //   }
                //   if (date == null)
                //  {
                //      return View(st);
                //  }
                //  return View(st);
            }
        }
    }
}