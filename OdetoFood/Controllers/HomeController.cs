using OdetoFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdetoFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();
        public ActionResult Index(string searchTerm = null)
        {
            var model = _db.Resturants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r=> searchTerm == null || r.Name.StartsWith(searchTerm))
                .Select(r => new ResturantListViewModel{
                Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
});
            //var model =
            //    from r in _db.Resturants
            //    orderby r.Reviews.Average(review => review.Rating) descending
            //    select new ResturantListViewModel
            //    {
            //        Id = r.Id,
            //        Name = r.Name,
            //        City = r.City,
            //        Country = r.Country,
            //        CountOfReviews = r.Reviews.Count()
            //    };
            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Jimbo";
            model.Location = "Dawsonville,GA";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db!=null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}