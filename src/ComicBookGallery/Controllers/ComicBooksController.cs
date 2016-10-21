using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();

        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View( comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            //var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);

            //ViewBag.SeriesTitle = "The Amazing Spider-Man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};

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

