using ASPBlog.Models;
using ASPBlog.TableClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.PostDate).Include(p => p.Author).ToList();
            return View(posts);
        }

    }
}