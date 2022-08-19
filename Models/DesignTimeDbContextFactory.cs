using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ParksMVC.Models
{
  public class ParksMVCContextFactory : IDesignTimeDbContextFactory<ParksMVCContext>
  {
    ParksMVCContext IDesignTimeDbContextFactory<ParksMVCContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<ParksMVCContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionString:DefaulConnection"]));

      return new ParksMVCContext(builder.Options);
    }
  }
}