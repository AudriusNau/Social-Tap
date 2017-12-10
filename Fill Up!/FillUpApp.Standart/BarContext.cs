using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace FillUpApp.Standart 
{
    public class BarContext : DbContext
    {
        public DbSet<Bar> Bars { get; set; }

        private string DatabasePath { get; set; }

        public BarContext()
        {

        }

        public BarContext(string databasePath)
        {
            DatabasePath = databasePath; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
