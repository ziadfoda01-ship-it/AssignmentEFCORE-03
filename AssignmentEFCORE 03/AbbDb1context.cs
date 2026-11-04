using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFCORE_03
{
    public class AbbDb1context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZIAD\\ZIAD;Database=EFCORE01;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Courses> courses { get; set; }
    }
}
