using Microsoft.EntityFrameworkCore;
using Projekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.DAL.Data
{
    public class ProjektContext : DbContext
    {
        public ProjektContext(DbContextOptions<ProjektContext> options) : base(options) { }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SportCentar> SportCentars { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<Terrain> Terrains { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole>UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjektContext).Assembly);
        }
    }
}
