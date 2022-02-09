using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_1640_Group24.Models;

namespace Web_1640_Group24.Controllers
{
    public class HomeController : Controller
    {
        IdeasDbContext db = new IdeasDbContext();
        public ActionResult Index()
        {
            List<Idea> ideas = db.Ideas.OrderByDescending(t => t.IdeaDateAndTime).ToList();
            return View(ideas);
        }
    }
}