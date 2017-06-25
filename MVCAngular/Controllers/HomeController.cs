using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAngular.Models;

namespace MVCAngular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeDetails model = new EmployeeDetails();
            List<Person> data = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                data.Add(new Person {
                    Id = Guid.NewGuid(),
                    Name = "Person " + i,
                    Mobile = GetGuid(),
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

        private string GetGuid() {
            var code = Guid.NewGuid().GetHashCode();
            return (Convert.ToInt64(code) * DateTime.Now.Ticks).ToString().Replace("-", "");
        }

    }
}