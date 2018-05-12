using System;
using ComicBookGallery.Models;
using ComicBookGallery.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController(){
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index(){
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            /*if( DateTime.Today.DayOfWeek == DayOfWeek.Tuesday){
                return Redirect("/");
            }

            return Content("Hello World");*/

            /*
            var comicBook = new ComicBook()
            {

                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]{
                    new Artist(){ Name = "Dan Slott", Role = "Script"},
                    new Artist(){ Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist(){ Name = "Victor Olazaba", Role = "Inks"},
                    new Artist(){ Name = "Edgar Delgado", Role = "Colors"},
                    new Artist(){ Name = "Chris Eliopoulos", Role = "Letters"},
                }

            };
            */

            /*           ViewBag.SeriesTitle = "The Amazing Spider-Man";
                       ViewBag.IssueNumber = 700;
                       ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
                       ViewBag.Artists = new string[]
                       {
                           "Script: Dan Slott",
                           "Pencils: Humberto Ramos",
                           "Inks: Victor Olazaba",
                           "Colors: Edgar Delgado",
                           "Letters: Chris Eliopoulos"
                       };*/
            if(id == null){
                //return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
       }
           
    }
    
}
