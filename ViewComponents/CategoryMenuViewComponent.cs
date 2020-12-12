using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent :  ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //{controller}/{action}/{id?}
            // /home/index/3
            // RouteData.Values[]
            if (RouteData.Values["action"].ToString() == "Index")
            {
                ViewBag.selectedCategory = RouteData?.Values["id"];
            }
            return View(CategoryRepository.Categories);
        }
    }
}
