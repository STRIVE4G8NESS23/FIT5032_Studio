using FIT5032_MyCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new MyDbContext())
            {
                var student = new Student
                {
                    FirstName = "Yilong",
                    LastName = "Liu"
                };

                context.Students.Add(student);
                context.SaveChanges();

                var unit = new Unit
                {
                    Name = "Math",
                    Description = "Mathematics Course",
                    StudentId = student.Id
                };

                context.Units.Add(unit);
                context.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}