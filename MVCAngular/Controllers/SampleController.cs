using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAngular.Models;

namespace MVCAngular.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            EmployeeDetails model = new EmployeeDetails();
            List<Person> data = new List<Person>();

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                data.Add(new Person
                {
                    Id = Guid.NewGuid(),
                    Name = "Person " + i,
                    Mobile = rnd.Next(70000, 99999).ToString() + rnd.Next(70000, 99999).ToString(),
                    Location = "Location " + i
                });
            }
            model.Members = data.ToList();

            return View(model);
        }

        public ActionResult SampleTableTemplate()
        {
            return View();
        }        
    }
}