using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BandRegister.Data
{
    public class BandRegisterDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-P8JABML\SQLEXPRESS;Database=BandRegisterDb;Trusted_Connection=True;";

        public DbSet<Band> Bands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
