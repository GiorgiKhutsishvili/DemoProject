using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProject.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace DemoProject.Controllers
{
    public class AccountController : Controller
    {
        DemoDBEntities db = new DemoDBEntities();
        // GET: Account
        public ActionResult Register()
        {
            var professions = new SelectList(db.ProfessionTbl.ToList(), "ID", "Profession");
            ViewData["DBProfessions"] = professions;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model, FormCollection formcollection)
        {
            var professions = new SelectList(db.ProfessionTbl.ToList(), "ID", "Profession");
            ViewData["DBProfessions"] = professions;

            var professionName = formcollection["ProfessionName"];
            
            if (ModelState.IsValid)
            {
                Person person = new Person();
                person.IdentityID = model.IdentityID;
                person.Name = model.Name;
                person.Surname = model.Surname;
                person.Birth_Date = model.Birth_Date;
                person.Phone = model.Phone;
                person.Profession = professionName;
                person.RegistrationDate = DateTime.Now;
                person.Status = "Active";
                db.Person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}