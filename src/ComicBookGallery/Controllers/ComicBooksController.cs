﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            return View();
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{
            //    return Redirect("/");
            //    //return new RedirectResult("/"); 
            //}

            //return Content("Hello from the comic book controller");
            ////return new ContentResult()
            ////{
            ////    Content = "Hello from the comic book controller"
            ////};
        }
    }

}
