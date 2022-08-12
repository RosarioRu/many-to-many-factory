using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq; 


namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;
    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    [HttpGet]
    public ActionResult Create()
    {
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Description");
      return View()
    }


  }
}