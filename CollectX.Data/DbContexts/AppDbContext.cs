using CollectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CollectX.Data.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}
