using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ShoeStore.Models;

namespace ShoeStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult months(string month)
        {
            return View();
        }

        public ActionResult ProblemDefinition()
        {
            return PartialView("ProblemDefinition");
        }
        public ActionResult MonthShoe(string id)
        {
            ViewBag.Title = id + "'s Shoes";
            List<Shoe> shoes = Shoe.GetAllShoes().FindAll(x => x.ReleaseMonth.ToLower().Trim() == id.ToLower().Trim());
            return PartialView("Shoes", shoes);
        }

        public ActionResult AllShoes()
        {
            ViewBag.Title = "AllShoe's";
            return PartialView("Shoes", Shoe.GetAllShoes());
        }

        public ActionResult BrandShoe(string id)
        {
            ViewBag.Title = id + "'s Shoes";
            List<Shoe> shoes = Shoe.GetAllShoes().FindAll(x => x.Brand.ToLower().Trim() == id.ToLower().Trim());
            return PartialView("Shoes", shoes);
        }

        [HttpGet]
        public ActionResult Subscribe(string id)
        {
            EmailAddressAttribute eAttribute = new EmailAddressAttribute();
            if (eAttribute.IsValid(id))
            {
                // call DB to store email address
                return Json(new { result = true, message = "Thanks! We will notify you of our new shoes at this email: " + id }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { result = false, message = "Invalid email format. Ex. name@example.com" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult PromoCode(string id)
        {
            // Tmp code defined.
            string[] promo = {"NOV2016", "2016ALL"};
            if (promo.Contains(id))
            {  
                // Process the code
                return Json(new { result = true, message = id + " has been applied!" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { result = false, message = "Invalid code format" }, JsonRequestBehavior.AllowGet);
        }

    }
}
