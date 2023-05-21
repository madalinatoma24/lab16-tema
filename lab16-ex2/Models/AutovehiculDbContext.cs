using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_ex2.Models
{
    internal class AutovehiculDbContext:DbContext
    {

        public AutovehiculDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Autovehicul> Autovehicule { get; set; }
        public DbSet<Producator> Producator { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\curs 3 lab  3 tema\lab16-tema\lab16-ex2\Autovehicule.mdf"";Integrated Security=True")
            .LogTo(Console.Write);
        }
    }
}
