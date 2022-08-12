using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq; 


namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      
      return View(_db.Machines.ToList());
      

    } 

    [HttpGet]
    public ActionResult Create()
    {
      ViewBag.EngineerId= new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machineToAdd, int EngineerId)
    {
      _db.Machines.Add(machineToAdd);
      _db.SaveChanges();
      if (EngineerId != 0)
      {
        _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineToAdd.MachineId, EngineerId = EngineerId});
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    
  }
}