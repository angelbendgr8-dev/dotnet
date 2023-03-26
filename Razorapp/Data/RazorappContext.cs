using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Razorapp.Models;


namespace Razorapp.Data
{
    public class RazorappContext : DbContext
    {
        static readonly string connectionString = "Server=localhost; User ID=root; Password=1243; Database=firstrazor";
        public RazorappContext(DbContextOptions<RazorappContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Razorapp.Models.Movie> Movie { get; set; } = default!;
    }
}
