using System.Linq;
using MVC486.Models;

namespace MVC486.Database 
{
    public class DbInitializer 
    {
        public static void Initialize(ConferenceContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            if (context.Speakers.Any())
              return;
            context.Speakers.Add(new Speaker {
                Name = "Arthur Brannigan",
                EmailAddress = "arthur@brannigan-enterprises.com"
            });
            context.SaveChanges();
        }

    }
}