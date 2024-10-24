using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
