using System;
using System.Collections.Generic; 


namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    // public string EngineerName { get; set; }
    public virtual Engineer Engineer { get; set; }
    public virtual Machine Machine { get; set; }
  }
}


