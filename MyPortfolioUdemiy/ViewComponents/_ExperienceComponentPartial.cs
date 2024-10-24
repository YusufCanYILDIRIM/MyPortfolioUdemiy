using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemiy.DAL.Context;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
