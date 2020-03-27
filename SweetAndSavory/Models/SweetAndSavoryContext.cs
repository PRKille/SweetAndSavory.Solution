using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats {get;set;}
    public DbSet<Flavor> Flavors {get;set;}
    public DbSet<TreatFlavor> TreatFlavors {get;set;}
    public SweetAndSavoryContext(DbContextOptions options) : base(options) { }
  }
}