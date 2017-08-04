
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC486.Database;
using MVC486.Models;

namespace MVC486.Controllers
{

    public class SpeakerController : CrudController<Speaker>
    {
        public SpeakerController(ConferenceContext ctx) : base(ctx)
        {
        }

        protected override DbSet<Speaker> RelevantDbSet => _ctx.Speakers;
        protected override string FriendlyIdentifier(Speaker item) => item.Name;

    }

}