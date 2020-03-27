using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats {get;set;}
    public DbSet<Flavor> Flavors {get;set;}
    public DbSet<Treat_Flavor> Treat_Flavors {get;set;}
    public SweetAndSavoryContext(DbContextOptions options) : base(options) { }
  }
}