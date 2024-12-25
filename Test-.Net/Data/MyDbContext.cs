using Microsoft.EntityFrameworkCore;
using Test_.Net.Models;

namespace Test_.Net.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(
        DbContextOptions<MyDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
    public DbSet<ComicBook> ComicBooks { get; set; }
}