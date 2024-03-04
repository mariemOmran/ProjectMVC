using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class StateController : Controller
    {
        public IActionResult GetSession()
        {
            String? name = HttpContext.Session.GetString( "Name");
            return Content(name);
        }
    }
}
