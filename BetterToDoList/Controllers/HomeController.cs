using Microsoft.AspNetCore.Mvc;

namespace BetterToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}