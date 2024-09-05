using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BrickThailand.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
 
        public ActionResult ProductCategory()
        {
            ViewBag.Message = "Your products page.";

            return View();
        }
        public ActionResult ProductList()
        {
            ViewBag.Message = "Your productsList page.";

            return View();
        }
        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your productsdetail page.";

            return View();
        }

        public ActionResult Game()
        {
            ViewBag.Message = "Your Game page.";

            return View();
        }

        public ActionResult Video()
        {
            ViewBag.Message = "Your Video page.";

            return View();
        }

        public ActionResult Store()
        {
            ViewBag.Message = "Your Store page.";

            return View();
        }

        public ActionResult StoreLocationDetails()
        {
            ViewBag.Message = "Your StoreLocationDetails page.";

            return View();
        }
      
       
    }
}
