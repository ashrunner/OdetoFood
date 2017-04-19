using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdetoFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]

        public ActionResult Search(string name = "french")
        {
            throw new System.Exception("Something Terrible has happened");
            var message = Server.HtmlEncode(name);
            return Content(message);
            //return RedirectPermanent("http://microsoft.com");
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default",new { controller = "Home",action = "About" });
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //return Json(new { Message = message, Name="Jimbo"},
            //    JsonRequestBehavior.AllowGet);

        }
       

    }
}