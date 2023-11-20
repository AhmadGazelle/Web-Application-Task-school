using SchoolWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWebApp.Controllers
{
    public class CourseController : Controller
    {
        Model1 md = new Model1();
        // GET: Cours
        public ActionResult Index()
        {
            List<Course> ListCours = new List<Course>();
            ListCours = (from a1 in md.Courses
                         select a1).ToList();


            return View(ListCours);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Course courses)
        {
            md.Courses.Add(courses);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Course c1 = new Course();
            c1 = (from a1 in md.Courses
                  where a1.ID == id
                  select a1).FirstOrDefault();
            md.Courses.Remove(c1);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Course c1 = new Course();
            c1 = (from a1 in md.Courses
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(c1);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Course c1 = new Course();
            c1 = (from a1 in md.Courses
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(c1);
        }
        [HttpPost]
        public ActionResult Update(Course courses)
        {
            Course c1 = new Course();
            c1 = (from a1 in md.Courses
                  where a1.ID == courses.ID
                  select a1).FirstOrDefault();
            c1.CourseName = courses.CourseName;
            c1.CourseNumber = courses.CourseNumber;
            md.SaveChanges();
            return RedirectToAction("Index", c1);
        }
    }
}