using Microsoft.EntityFrameworkCore;
using MVC486.Models;

namespace MVC486.Database 
{
    public class ConferenceContext : DbContext
    {
        public ConferenceContext(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<Speaker> Speakers {get; set; }
        public DbSet<Session> Sessions {get; set; }

        protected override void OnModelCreating(ModelBuilder mb) 
        {
            mb.Entity<Speaker>().ToTable("Speaker");
            mb.Entity<Session>().ToTable("Session");
        }
    }
}