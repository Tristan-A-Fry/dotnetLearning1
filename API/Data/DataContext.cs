using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    //Base refers to the base class in this case it is Dbcontext
    // We will provide the options in another area
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<AppUser> Users { get; set; }
}