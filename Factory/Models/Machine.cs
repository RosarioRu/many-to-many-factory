using System;
//using System.Collections.Generic; (for lists)


namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Description {get; set; }
    public int Value {get; set}
    public virgual ICollection<EngineerMachine> JoinEntities { get; set; }


  }
}
