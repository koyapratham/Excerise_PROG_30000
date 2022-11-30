using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Persistance

{
    public class Database : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=exercise.db");
        }
    }
}