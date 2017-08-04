using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC486.Database;
using MVC486.Models;

namespace MVC486.Controllers
{

    public abstract class CrudController<T> : Controller where T : class
    {
        protected readonly ConferenceContext _ctx;

        protected CrudController(ConferenceContext ctx)
        {
            _ctx = ctx;
        }

        protected abstract DbSet<T> RelevantDbSet { get; }

        protected abstract string FriendlyIdentifier(T item);

        public ActionResult Index()
        {
            var all = RelevantDbSet.ToList();
            return View(all);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(T item)
        {
            if (!ModelState.IsValid)
                return View(item);

            try
            {
                RelevantDbSet.Add(item);
                _ctx.SaveChanges();
            }
            catch (Exception x)
            {
                ModelState.AddModelError("Error", x.Message);
                return View(item);
            }
            // Need session for this shenanigan:
            //TempData["Message"] = $"Created {FriendlyIdentifier(item)}";
            return RedirectToAction("Index");
        }
    }
}