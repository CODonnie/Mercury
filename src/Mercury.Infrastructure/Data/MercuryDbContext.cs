using Microsoft.EntityFrameworkCore;
using Mercury.Domain.Entities;

namespace Mercury.Infrastructure.Data;

public class MercuryDbContext : DbContext
{
  public MercuryDbContext(DbContextOptions<MercuryDbContext>options) 
    : base(options)
  {
  }

  public DbSet<User> Users => Set<User>();
}
