using AspExos.Models;
using Microsoft.EntityFrameworkCore;

namespace AspExos.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AspExosDb;Integrated Security=True");

    }

}
