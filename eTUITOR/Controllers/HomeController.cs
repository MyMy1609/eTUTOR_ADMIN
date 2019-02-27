using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eTUITOR.Models;

namespace eTUITOR.Controllers
{
    public class HomeController : Controller
    {
        eTUTOREntities model = new eTUTOREntities();
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index( string email, string password)
        {
           ;
            var admin = model.admins.FirstOrDefault(x => x.email == email);
            if (admin != null)
            {
                if (admin.password.Equals(password))
                {
                    Session["FullName"] = admin.fullname;
                    Session["UserID"] = admin.admin_id;
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            else
            {
                ViewBag.mgs = "tài khoản không tồn tại";
            }
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
        


