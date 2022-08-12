using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 


namespace Factory.Models
{
  public class Engineer
  {

    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    [Display(Name = "Engineer's ID")]
    public int EngineerId { get; set; }

    [Display(Name = "Full Name")]
    public string EngineerName { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities {get; set; }

  }
}

