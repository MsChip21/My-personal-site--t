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

        [HttpGet]
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
        public IActionResult Contact(ContactModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["FormResult"] = "اطلاعات وارد شده صحیح نیست";
                return View(form);
            }

            ViewData["FormResult"] = "پیغام شما با موفقیت ارسال شد.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}