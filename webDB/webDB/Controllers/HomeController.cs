using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webDB.Models;
using webDB.Repository;

namespace webDB.Controllers
{
    public class HomeController : Controller
    {
        LivroRepository repor = new LivroRepository();

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public ActionResult Create(Livros model)
        {

            repor.Create(model);

            return RedirectToAction("Read");
        }

        public ActionResult Read()
        {
            return View(repor.Read());
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(repor.Read(id));
        }

        [HttpPost]
        public ActionResult Update(Livros model)
        {
            repor.Updade(model);
            return RedirectToAction("Read");
        }


        public ActionResult Delete(int id)
        {
            repor.Delete(id);
            return RedirectToAction("Read");
        }


    }
}