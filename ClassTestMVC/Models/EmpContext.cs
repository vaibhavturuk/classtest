using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClassTestMVC.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext()
                : base("EmpDbContext")
        {
        }

        public DbSet<Emp> Emps { get; set; }
        public DbSet<Ste> Stes { get; set; }
        public DbSet<City> citys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Week_5");
        }
    }
}