using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
    public static class CampContextFluentRules
    {
        public static void ConfigureCampEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camp>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property<string>(c => c.Name).IsRequired(true);
                entity.Property<byte[]>(c => c.RowVersion).IsRowVersion();
                entity.HasMany<Speaker>(c => c.Speakers).WithOne(s => s.Camp);
            });
        }

        public static void ConfigureLocationEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(l => l.Id);
                entity.Property<byte[]>(l => l.RowVersion).IsRowVersion();
            });
        }

        public static void ConfigureSpeakerEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property<byte[]>(s => s.RowVersion).IsRowVersion();
                entity.HasOne<Camp>(s => s.Camp).WithMany(c => c.Speakers);
                entity.HasOne<CampUser>(s => s.User);
                entity.HasMany<Talk>(s => s.Talks).WithOne(t => t.Speaker);
            });
        }

        public static void ConfigureTalkEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talk>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property<byte[]>(t => t.RowVersion).IsRowVersion();
                entity.HasOne<Speaker>(t => t.Speaker).WithMany(s => s.Talks);
            });
        }

        public static void ConfigureCampUserEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampUser>(entity =>
            {
                entity.HasKey(cu => cu.Id);
                entity.Property<byte[]>(cu => cu.RowVersion).IsRowVersion();
            });
        }
    }
}