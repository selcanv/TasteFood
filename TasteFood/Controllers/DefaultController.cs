using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFood.Entities;
using TasteFood.Context;

namespace TasteFood.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext(); 
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Addresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Addresses.Select(y => y.Email).FirstOrDefault();
            ViewBag.description = context.Addresses.Select(z => z.Description).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.title = context.Abouts.Select(y => y.Title).FirstOrDefault();
            ViewBag.imageUrl = context.Abouts.Select(z => z.ImageUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }

        public PartialViewResult PartialChef()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialSecrets()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooterInfo()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}