using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirstq2.Models;
using System.Data.Entity;
namespace Codefirstq2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MovieContext db = new MovieContext();
        public ActionResult Index()
        {
            var movies = db.movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(movie movie)
        {
            db.movies.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = db.movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(movie movie)
        {
            db.movies.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var movie = db.movies.Find(id);
            db.movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}