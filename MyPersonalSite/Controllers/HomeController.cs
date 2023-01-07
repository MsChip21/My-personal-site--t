using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPersonalSite.Models;

namespace MyPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new ContactModel();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(name);
        //}

        [HttpPost]
        public JsonResult Contact(ContactModel form)
        {
            Console.WriteLine(form.ToString);
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}