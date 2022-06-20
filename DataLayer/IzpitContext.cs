using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class IzpitContext : DbContext
    {
        public IzpitContext()
        {

        }
        public IzpitContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-DR145US\\SQLEXPRESS;Database=IzpitDB;Trusted_Connection=True;");
            }
        }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<RPU> RPUs { get; set; }



            }
}
