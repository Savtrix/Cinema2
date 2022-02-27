
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Cinema.Models;

namespace Cinema.Data
{
    public class CinemaContext : IdentityDbContext
    {
        public CinemaContext (DbContextOptions<CinemaContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cinema.Models.Employee> Employee { get; set; }

        public DbSet<Cinema.Models.Movie> Movie { get; set; }

        public DbSet<Cinema.Models.Room> Room { get; set; }
    }
}
