using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }
    // example route below:
    // [Route("/")]
    // public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}