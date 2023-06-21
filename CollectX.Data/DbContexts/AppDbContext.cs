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
    public DbSet<Like> Likes { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<CustomField> CustomFields { get; set; }



}
