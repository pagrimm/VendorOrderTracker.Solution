using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}