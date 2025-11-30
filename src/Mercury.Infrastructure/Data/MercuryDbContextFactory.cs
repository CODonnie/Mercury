using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mercury.Infrastructure.Data;

public class MercuryDbContextFactory: IDesignTimeDbContextFactory<MercuryDbContext>
{
  public MercuryDbContext CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<MercuryDbContext>();
    optionsBuilder.UseSqlite("Data Source=mercury.db");

    return new MercuryDbContext(optionsBuilder.Options);
  }
}
