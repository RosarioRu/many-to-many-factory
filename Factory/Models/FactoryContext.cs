using Microsoft.EntityFrameworkCore;

namespace Facotry.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<EngineerMachine> EngineerMachines { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}