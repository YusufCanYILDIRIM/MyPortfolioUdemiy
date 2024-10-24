using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
