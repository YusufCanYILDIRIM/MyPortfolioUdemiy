﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemiy.DAL.Context;

namespace MyPortfolioUdemiy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList(); 
            return View(values);
        }
    }
}
