using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMVC.Models;
namespace BlogMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //First three posts
            var db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Id).Take(3).ToList();           
            return View(posts);
        }       
    }
}