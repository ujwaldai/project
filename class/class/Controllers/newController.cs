using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using work.Models;

namespace work.Controllers
{
   

    public class newController : Controller
    {
        daiEntities db = new daiEntities();
    // GET: new
        public ActionResult ADD()
        {
            return View();
        }
        public ActionResult Add()
        {
        return View();
        }
    }
}