using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
