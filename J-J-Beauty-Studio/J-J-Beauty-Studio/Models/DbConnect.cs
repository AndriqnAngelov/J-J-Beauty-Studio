using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using J_J_Beauty_Studio.Models;

namespace J_J_Beauty_Studio.Models
{
    public class DbConnect: DbContext
    {
        public DbSet<Preservation> preservation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectString = @"Server=.\SQLEXPRESS;Database=JJDatabase;Integrated Security = True";
            optionsBuilder.UseSqlServer(connectString);
        }
    }
}
