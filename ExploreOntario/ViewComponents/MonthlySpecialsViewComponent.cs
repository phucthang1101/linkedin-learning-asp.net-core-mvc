using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreOntario.Models;
using Microsoft.AspNetCore.Mvc;
namespace ExploreOntario.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly BlogDataContext db;

        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = db.MonthlySpecial.ToArray();
            return View(specials);
        }
    }
}
