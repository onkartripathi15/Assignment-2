using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DataContext
{
    class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=CPU-0191; Initial Catalog=config;Trusted_Connection=True");
        }
        public DbSet<UserClass> userdisplay { get; set; }
    }
}
