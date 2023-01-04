using Microsoft.AspNetCore.Mvc;
using MyPersonalSite.Models;

namespace MyPersonalSite.ViewComponents
{
    public class NewsViewComponent : ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            var news = new List<NewsModel>()
            {
                new NewsModel(1,"خورشید پشتش به ماست","تاحالا میدونستی که خورشید پشتش به ماست و اگر برگرده اینو تمام کوه و درخت اینارو میسوزونه ؟","blog-post-thumb-1.jpg"),
                new NewsModel(2,"هابیل قابیل را کشت","طی یک حرکت عجیب هابیل قابیل را کشت","blog-post-thumb-2.jpg"),
                new NewsModel(3,"شوروی سقوط کرد و دستش شکست","شوروی از طبقیه دوم ساختمان نیمه کاره سقوط کرد و دست و پایش شکست","blog-post-thumb-3.jpg"),
                new NewsModel(4,"ماه تنها قمر زمین است","تابحال میدانستید که ماه تنها قمر زمین است ؟","blog-post-thumb-4.jpg")
            };
            return View("News",news);
        }
    }
}
