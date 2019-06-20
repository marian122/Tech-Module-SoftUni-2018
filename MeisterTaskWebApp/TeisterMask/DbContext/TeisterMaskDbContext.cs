namespace TeisterMask.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Models;

    public class TeisterMaskDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-Q8BQNI9\SQLEXPRESS;Database=TeisterMaskDb;Trusted_Connection=True;";

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
