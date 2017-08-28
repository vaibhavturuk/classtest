using ClassTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassTestMVC.Controllers
{
    public class HomeController : Controller
    {
        EmpContext context = new EmpContext();
         public ActionResult Index()
        {
            return View();

        }
        public ActionResult Create()
        {
            Emp e = new Emp();
            var Cities = context.citys.ToList();
            var states = context.Stes.ToList();
            var viewModel = new EmpViewModel
            {
                Name = e.Name,
                Email = e.Email,
                Phone = e.Phone,
                MaritalStatus = e.MaritalStatus,

                City = Cities,
                Ste = states,

        };
            return View("Create", viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpViewModel person)
        {

            if (ModelState.IsValid)
            {
                context.Emps.Add(person.Employee);
                context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public ActionResult EmpDetails()
        {
            Emp emp = TempData["Emp"] as Emp;
            return View(emp);
        }


        public ActionResult GetData()
        {
            using (EmpContext db = new EmpContext())
            {
                var NewUserData = db.Emps.OrderBy(a => a.Name).ToList();
                return Json(new { data = NewUserData }, JsonRequestBehavior.AllowGet);
            }
        }
       


    }
}