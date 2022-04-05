using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Models
{
    public class newController : Controller
    {
        daiEntities1 db = new daiEntities1();
        // GET: new
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Viewdata()
        {
            List<employee> all_data = db.employees.ToList();
            return View(all_data);
        }
        public ActionResult SaveData(employee tbl_employee)
        {
            db.employees.Add(tbl_employee);
            db.SaveChanges();
            return RedirectToAction("ViewData");
        }
        public ActionResult AddData()
        {
            return View();
        }
    }
}