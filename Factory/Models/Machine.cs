using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 


namespace Factory.Models
{
  public class Machine
  {
    public Machine() 
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    [Display(Name = "Machine ID")]
    public int MachineId { get; set; }

    [Display(Name = "Machine Name")]
    public string MachineName { get; set; }
    
    public string Description {get; set; }
    public int Value {get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }


  }
}
