using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Ques2.Models;
using MVC_Ques2.Models.Repository;

namespace MVC_Ques2.Controllers
{
    public class MovieController : Controller

    {
        IRepository<Movies> _repository = null;

        public MovieController()
        {
            _repository = new Repository<Movies>();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _repository.GetAll();
            return View(movies);

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _repository.insert(movie);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
        }
        public ActionResult Edit(int mid)
        {
            var movie = _repository.GetById(mid);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movies m)
        {
            if (ModelState.IsValid)
            {
                _repository.update(m);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }

        public ActionResult Details(int mid)
        {
            var movie = _repository.GetById(mid);
            return View(movie);
        }
        public ActionResult Delete(int mid)
        {
            var movie = _repository.GetById(mid);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int mid)
        {
            var product = _repository.GetById(mid);
            _repository.delete(mid);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}