using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using feri.Models;

namespace feri.Controllers
{
    public class newController : Controller
    {
        // GET: new
       
        daiEntities1 db = new daiEntities1();
        // GET: Nayaaa
        public ActionResult ShowDetails()
        {
            List<employee1> all_data = db.employees1.ToList();
            return View(all_data);
        }
        public ActionResult create_employee()
        {
            return View();
        }
        public ActionResult SaveData(employee1 tbl_employees)
        {
            db.employees1.Add(tbl_employees);
            db.SaveChanges();
            return RedirectToAction("ShowDetails");
        }
       
        
    }
}
