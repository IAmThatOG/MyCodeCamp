using System;
using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
    public class CampContext : DbContext
    {
        public CampContext(DbContextOptions<CampContext> options) : base(options) { }

        public DbSet<Camp> Camps { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<CampUser> CampUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConfigureCampEntity();
            modelBuilder.ConfigureCampUserEntity();
            modelBuilder.ConfigureLocationEntity();
            modelBuilder.ConfigureSpeakerEntity();
            modelBuilder.ConfigureTalkEntity();
            modelBuilder.SeedLocation();
            modelBuilder.SeedCamps();
            modelBuilder.SeedSpeakers();
            modelBuilder.SeedTalks();
        }
    }
}
