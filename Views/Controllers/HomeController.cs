using Microsoft.AspNetCore.Mvc;

namespace MVC486 
{

    public class HomeController : Controller 
    {
        public ActionResult Index() {
            return View();
        }
        
    }

}