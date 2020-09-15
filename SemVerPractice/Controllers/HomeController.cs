using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SemVerPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Reflection.Assembly assembly = typeof(HomeController).Assembly;

            var assemblyName = assembly.GetName().Name;
            var gitVersionInformationType = assembly.GetType("GitVersionInformation");
            var fields = gitVersionInformationType.GetFields();

            foreach (var field in fields)
            {
                Console.WriteLine(string.Format("{0}: {1}", field.Name, field.GetValue(null)));
            }


            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
