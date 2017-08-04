using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC486.Database;
using MVC486.Models;

namespace MVC486
{
    [Route("api/[controller]/[action]")]
    public class DataController : Controller
    {
        private readonly ConferenceContext _ctx;

        public DataController(ConferenceContext ctx) => _ctx = ctx;

        [HttpGet]
        public IEnumerable<Session> Sessions() => _ctx.Sessions.ToList();

        [HttpGet]
        public IEnumerable<Speaker> Speakers() => _ctx.Speakers.ToList();
    }
}