using Microsoft.EntityFrameworkCore;
using MSTestEmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MSTestEmployeeProject.DataAccess
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            //string path = "D:\\Rahul_Task\\MSTestProject\\MSTestEmployeeProject\\bin\\Debug\\netstandard2.0";
            if(!File.Exists(Path.Combine(path, "EmployeeDB.db")))
            {
                File.Create(Path.Combine(path, "EmployeeDB.db"));
            }
            OptionsBuilder.UseSqlite("Data Source=" + Path.Combine(path, "EmployeeDB.db") + ";");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Employee required
            modelBuilder.Entity<Employee>();

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
