using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naya_project.Models;

namespace naya_project.Controllers
{
    public class arkoController : Controller
    {

        daiEntities1 db = new daiEntities1();
        // GET: arko
        public ActionResult nayaa()
        {
            List<student> all_data = db.students.ToList();
            return View(all_data );
        }
        public ActionResult create()
        {
            return View();
        }
    }
}