using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemiy.Views.Shared.Components
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
