using Microsoft.AspNetCore.Mvc;
using MyPersonalSite.Models;

namespace MyPersonalSite.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<ProjectModel>()
            {
                new ProjectModel(1,"SHN","برنامه مدیریت کاربران به صورت نقشه سه بعدی ارتباطات","Mabna","project-1.jpg"),
                new ProjectModel(2,"سایت نشریه پیرامون","سایت نشریه پیرامون با وردپرس که در حال حاظر این پروژه تکمیل شده","Mabna","project-2.jpg"),
                new ProjectModel(3,"آخرین دفاع","بازی که در حال حاظر در دست ساخت است","TahaDashti","project-3.jpg"),
                new ProjectModel(4,"مدرسه علم و فرهنگ","سایت مدرسه علم و فرهنگ که قرار است با استفاده از وردپرس ساخته شود در بهمن ماه","ElmoFarhang","project-4.jpg")
            };
            return View("MySampleJob",projects);
        }
    }
}
