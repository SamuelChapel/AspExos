using AspExos.Models;
using Microsoft.EntityFrameworkCore;

namespace AspExos.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Message> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MSI; Initial Catalog=AspExos; Integrated Security=SSPI; TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Message>().HasData(Message.GetRandomMessages(100));
    }
}
