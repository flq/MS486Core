
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC486.Database;
using MVC486.Models;

namespace MVC486.Controllers
{

    public class SessionController : CrudController<Session>
    {
        
        public SessionController(ConferenceContext ctx) : base(ctx)
        {
        }

        protected override DbSet<Session> RelevantDbSet => _ctx.Sessions;
        protected override string FriendlyIdentifier(Session item) => item.Title;

        public ActionResult GetSessionByTitle(string title)
        {
            var session = (from s in _ctx.Sessions
                           where s.Title == title
                           select s).FirstOrDefault();
            return View("Session", session);
        }

    }

}