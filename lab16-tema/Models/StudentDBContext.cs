using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16_tema.Models
{
    internal class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\curs 3 lab  3 tema\lab16-tema\lab16-tema\Students.mdf"";Integrated Security=True")
            .LogTo(Console.Write);
        }
    }
}
