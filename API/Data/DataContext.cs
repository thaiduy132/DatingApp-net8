using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }


    // This will be a table "Users" in our database
    public DbSet<AppUser> Users { get; set; } 

}