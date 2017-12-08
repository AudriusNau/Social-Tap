using Microsoft.EntityFrameworkCore;
using System;

namespace FillUpApp.Standart
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bar> Bars { get; set; }
        private readonly string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
