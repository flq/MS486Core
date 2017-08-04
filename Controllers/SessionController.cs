
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC486.Database;
using MVC486.Models;

namespace MVC486.Controllers
{

    public class SessionController : Controller
    {
        private ConferenceContext _ctx;

        public SessionController(ConferenceContext ctx)
        {
            _ctx = ctx;
        }

        public ActionResult Index()
        {
            var all = _ctx.Sessions.ToList();
            return View(all);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid)
                return View(session);

            try
            {
                _ctx.Sessions.Add(session);
                _ctx.SaveChanges();
            }
            catch (Exception x)
            {
                ModelState.AddModelError("Error", x.Message);
                return View(session);
            }
            TempData["Message"] = $"Created {session.Title}";
            return RedirectToAction("Index");
        }

        public ActionResult GetSessionByTitle(string title)
        {
            var session = (from s in _ctx.Sessions
                           where s.Title == title
                           select s).FirstOrDefault();

            return View("Session", session);
        }

    }

}