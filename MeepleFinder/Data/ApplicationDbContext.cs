using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MeepleFinder.Models;

namespace MeepleFinder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Person> Person { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<GameRatings> GameRatings { get; set; }
        public DbSet<Location> Location { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
