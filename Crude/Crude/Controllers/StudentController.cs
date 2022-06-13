using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crude.Models.EF;

namespace Crude.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
       
        
        // seeing student list
        public ActionResult Index()
        {
            var db = new CrudEntities();
            var students = db.Students.ToList();
            return View(students);
        }

        public ActionResult Delete(int id)
        {
            var db = new CrudEntities();
            var student=(from s in db.Students where s.Id == id select s).FirstOrDefault();
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                var db = new CrudEntities();
                db.Students.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(st);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var db = new CrudEntities();
            var student = (from s in db.Students where s.Id == id select s).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Update(Student st)
        {
            if (ModelState.IsValid)
            {
                var db = new CrudEntities();
                var student = (from s in db.Students
                               where s.Id == st.Id
                               select s).FirstOrDefault();
                db.Entry(student).CurrentValues.SetValues(st);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(st);
        }
    }
}