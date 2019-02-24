using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTUITOR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Login admin.";
            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Course Management.";
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard.";
            return View();
        }

        public ActionResult DetailParent()
        {
            ViewBag.Message = "Detail Parent.";
            return View();
        }

        public ActionResult DetailStudent()
        {
            ViewBag.Message = "Detail Student.";
            return View();
        }

        public ActionResult DetailTutor()
        {
            ViewBag.Message = "Detail Tutor.";
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Message = "Detail.";
            return View();
        }

        public ActionResult User()
        {
            ViewBag.Message = "User.";
            return View();
        }
    }
}