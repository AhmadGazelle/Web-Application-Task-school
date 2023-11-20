using SchoolWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWebApp.Controllers
{
    public class TetcherController : Controller
    {
        Model1 md = new Model1();
        // GET: Tetcher
        public ActionResult Index()
        {
            List<Tetcher> listTetcher = new List<Tetcher>();
            listTetcher = (from a1 in md.Tetchers
                           select a1).ToList();


            return View(listTetcher);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Tetcher tetchers)
        {
            md.Tetchers.Add(tetchers);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Tetcher T1 = new Tetcher();
            T1 = (from a1 in md.Tetchers
                  where a1.ID == id
                  select a1).FirstOrDefault();
            md.Tetchers.Remove(T1);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Tetcher T1 = new Tetcher();
            T1 = (from a1 in md.Tetchers
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(T1);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Tetcher T1 = new Tetcher();
            T1 = (from a1 in md.Tetchers
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(T1);
        }
        [HttpPost]
        public ActionResult Update(Tetcher tetchers)
        {
            Tetcher T1 = new Tetcher();
            T1 = (from a1 in md.Tetchers
                  where a1.ID == tetchers.ID
                  select a1).FirstOrDefault();
            T1.TetcherName = tetchers.TetcherName;
            T1.Major = tetchers.Major;
            md.SaveChanges();
            return RedirectToAction("Index", T1);
        }
    }
}
