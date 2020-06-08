using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace m151.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=mssql.gibz.thommenmedia.ch\mssqllocaldb;Database=m151-beutler;Integrated Security=True");
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}