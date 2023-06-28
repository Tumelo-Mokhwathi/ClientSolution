using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-LI621PO8\\SQLEXPRESS;Initial Catalog=ClientDB;Integrated Security=True");
        }


    }
}
