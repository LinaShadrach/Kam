using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Kam.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Photo_Position> Photo_Positions { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public ApplicationDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Kam;integrated security=True");
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}