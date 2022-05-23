using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_TASK.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
       // public ActionResult Index()
        //{
       //     return View();
      //  }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Personal()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}