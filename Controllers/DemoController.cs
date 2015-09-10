using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniqueAttribute.Models;

namespace UniqueAttribute.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TestModel Model)
        {
            if (ModelState.IsValid)
            {
                db.test.Add(Model);
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult Update(int Id)
        {
            return View(db.test.Find(Id));
        }

        [HttpPost]
        public ActionResult Update(TestModel Model)
        {
            var data = db.test.Find(Model.Id);
            if (ModelState.IsValid)
            {
                data.SomeThing = Model.SomeThing;
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult List()
        {
            return View(db.test.ToList());
        }

    }
}
