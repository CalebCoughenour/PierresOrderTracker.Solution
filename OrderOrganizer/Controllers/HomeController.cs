using Microsoft.AspNetCore.Mvc;

namespace OrderOrganizer.Controllers
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