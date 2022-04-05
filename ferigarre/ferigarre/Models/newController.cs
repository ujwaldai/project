using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ferigarre.Models
{
    public class newController : Controller
    {
        daiEntities db = new daiEntities();

        // GET: new
        public ActionResult View()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        public ActionResult create()
        {
            return View();
        }
  
        
        public ActionResult SaveData( employee tbl_employee)
        {
            db.employees.Add(tbl_employee);
            db.SaveChanges();
            return RedirectToAction("employee");
        }
    }
   
}