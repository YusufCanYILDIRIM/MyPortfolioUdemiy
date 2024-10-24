using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
