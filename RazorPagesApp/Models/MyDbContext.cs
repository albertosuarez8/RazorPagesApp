﻿using Microsoft.EntityFrameworkCore;

namespace RazorPagesApp.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
