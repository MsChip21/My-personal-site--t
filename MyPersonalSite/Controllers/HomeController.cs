using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPersonalSite.Models;

namespace MyPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<ServicesModel> _services = new List<ServicesModel>()
        {
            new ServicesModel(1,"نقره ای"),
            new ServicesModel(2,"طلائی"),
            new ServicesModel(3,"پلاتین"),
            new ServicesModel(4,"الماس")
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactModel()
            {
                Services = new SelectList(_services,"id","name")
            };
            return View(model);
        }

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