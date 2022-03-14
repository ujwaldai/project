using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using feri.Models;

namespace feri.Controllers
{

    public class NayaaaController : Controller
    {
        daiEntities1 db = new daiEntities1();
        // GET: Nayaaa
        public ActionResult employee()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            return View();
        }
        public ActionResult SaveData(employee tbl_employee)
        {
            db.employees.Add(tbl_employee);
            db.SaveChanges();
            return RedirectToAction("employee");
        }
        public ActionResult Edit(int id)
        {
            employee data=db.employees.Find(id);
            return View(data);
        }
        public ActionResult EditData(employee tbl_employee)
        {
            
            db.Entry(tbl_employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("employee");
           
   
        }
    }
}