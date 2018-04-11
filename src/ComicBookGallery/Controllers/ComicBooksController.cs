using System;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if( DateTime.Today.DayOfWeek == DayOfWeek.Tuesday){
                return Redirect("/");
            }

            return Content("Hello World");
       }
           
    }
    
}
