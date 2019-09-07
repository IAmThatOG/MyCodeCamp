using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
    public static class CampContextFluentRules
    {
        public static void ConfigureCampEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camp>().HasKey(c => c.Id);
            modelBuilder.Entity<Camp>().Property<string>(c => c.Name).IsRequired(true);
            modelBuilder.Entity<Camp>().Property<long>(c => c.RowVersion).IsRowVersion();
            modelBuilder.Entity<Camp>().HasMany<Speaker>(c => c.Speakers).WithOne(s => s.Camp);
        }

        public static void ConfigureLocationEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasKey(l => l.Id);
            modelBuilder.Entity<Location>().Property<long>(l => l.RowVersion).IsRowVersion();
        }

        public static void ConfigureSpeakerEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>().HasKey(s => s.Id);
            modelBuilder.Entity<Speaker>().Property<long>(s => s.RowVersion).IsRowVersion();
            modelBuilder.Entity<Speaker>().HasOne<Camp>(s => s.Camp).WithMany(c => c.Speakers);
            modelBuilder.Entity<Speaker>().HasMany<Talk>(s => s.Talks).WithOne(t => t.Speaker);
        }

        public static void ConfigureTalkEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talk>().HasKey(t => t.Id);
            modelBuilder.Entity<Talk>().Property<long>(t => t.RowVersion).IsRowVersion();
            modelBuilder.Entity<Talk>().HasOne(t => t.Speaker).WithMany(s => s.Talks);
        }

        public static void ConfigureCampUserEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampUser>().HasKey(cu => cu.Id);
            modelBuilder.Entity<CampUser>().Property<long>(cu => cu.RowVersion).IsRowVersion();
        }
    }
}