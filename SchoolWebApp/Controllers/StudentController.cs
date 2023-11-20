using SchoolWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolWebApp.Controllers
{
    public class StudentController : Controller
    {
        Model1 md = new Model1();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = (from a1 in md.Students
                           select a1).ToList();


            return View(listStudent);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            md.Students.Add(student);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Student s1 = new Student();
            s1 = (from a1 in md.Students
                  where a1.ID == id
                  select a1).FirstOrDefault();
            md.Students.Remove(s1);
            md.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Student s1 = new Student();
            s1 = (from a1 in md.Students
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(s1);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Student s1 = new Student();
            s1 = (from a1 in md.Students
                  where a1.ID == id
                  select a1).FirstOrDefault();

            return View(s1);
        }
        [HttpPost]
        public ActionResult Update(Student student)
        {
            Student s1 = new Student();
            s1 = (from a1 in md.Students
                  where a1.ID == student.ID
                  select a1).FirstOrDefault();
            s1.FirstName = student.FirstName;
            s1.LastName = student.LastName;
            s1.Address = student.Address;
            md.SaveChanges();
            return RedirectToAction("Index", s1);
        }
    }
}