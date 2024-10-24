using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
