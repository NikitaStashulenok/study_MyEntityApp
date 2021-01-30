using Microsoft.EntityFrameworkCore;
using MyEntityApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEntityApp.Controller
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=myentityapp;Trusted_Connection=True;");
        }
    }
}
