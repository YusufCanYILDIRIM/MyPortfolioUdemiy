using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemiy.DAL.Context;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle =portfolioContext.Abouts.Select(a => a.Title).ToList().FirstOrDefault();  
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(a=>a.SubDescription).ToList().FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(a=>a.Details).ToList().FirstOrDefault();
            return View();
        }
    }
}
