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
        public ActionResult Logout(int id)
        {
            var user = model.admins.FirstOrDefault(x => x.admin_id == id);
            if (user != null)
            {
                Session["FullName"] = null;
                Session["UserID"] = null;
            }
            return RedirectToAction("Login");
        }
        public ActionResult Course()
        {
            var tutor_id = int.Parse(Session["UserID"].ToString());
            var info = model.tutors.FirstOrDefault();
            List<session> sessionList = model.sessions.Where(x => x.status_tutor == 1 && x.status_admin == 2).ToList();
            ViewData["sessionlist"] = sessionList;
            return View(info);
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
            return View();
        }



        [HttpPost]
        public ActionResult Duyetkhoahoc(int id)
        {
            int asd = id;
            var se = model.sessions.Find(id);
            se.status_admin = 1;
            model.SaveChanges();
            return RedirectToAction("Duyetkhoahoc");
        }

        public ActionResult Contact()
        {
            var contact = model.contact_admin.ToList();
            return View(contact);
        }

        public ActionResult Blockuser()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Duyettutor(int id)
        {
            int asd = id;
            var se = model.tutors.Find(id);
            se.status = 1;
            model.SaveChanges();
            return RedirectToAction("Duyettutor");
        }

        [HttpPost]
        public ActionResult Duyetparent(int id)
        {
            int asd = id;
            var se = model.parents.Find(id);
            se.status = 1;
            model.SaveChanges();
            return RedirectToAction("Duyetparent");
        }

        [HttpPost]
        public ActionResult Duyetstudent(int id)
        {
            int asd = id;
            var se = model.students.Find(id);
            se.status = 1;
            model.SaveChanges();
            return RedirectToAction("Duyetstudent");
        }
    }
}
        


