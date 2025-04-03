using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class BD : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud;Integrated Security=True");
        }
    }
}
