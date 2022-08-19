using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
// using ParksMVC.Migrations;

namespace ParksMVC.Models
{
  public class ParksMVCContext : IdentityDbContext<ApplicationUser>
  {
    public ParksMVCContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}