using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProject.Models;
using System.Data.Entity;
using System.Diagnostics;
using System.Reflection;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        DemoDBEntities db = new DemoDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var person = db.Person.ToList();
            return View(person);
        }

        [HttpPost]
        public JsonResult ConfirmCancel(int id)
        {
            Person person = db.Person.Find(id);
            person.CancelDate = DateTime.Now;
            person.Status = "inActive";
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return Json("CancelSucceeded", JsonRequestBehavior.AllowGet);
        }
    }
}