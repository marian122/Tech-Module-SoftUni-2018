namespace Library.DbContext
{
    using Library.Models;
    using Microsoft.EntityFrameworkCore;

    public class BookDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-Q8BQNI9\SQLEXPRESS;Database=TeisterMaskDb;Trusted_Connection=True;";

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
