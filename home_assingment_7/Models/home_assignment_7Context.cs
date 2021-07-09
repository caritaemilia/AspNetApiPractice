using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace home_assingment_7.Models
{
    public partial class home_assignment_7Context : DbContext
    {
        public home_assignment_7Context()
        {
        }

        public home_assignment_7Context(DbContextOptions<home_assignment_7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Levels> Levels { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Scores> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("your address here");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Finland.1252");

            modelBuilder.Entity<Levels>(entity =>
            {
                entity.ToTable("levels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.ToTable("players");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Scores>(entity =>
            {
                entity.ToTable("scores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HighScore).HasColumnName("high_score");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.TimeInSeconds).HasColumnName("time_in_seconds");

                entity.Property(e => e.TimeStamp).HasColumnName("time_stamp");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scores_level_id_fkey");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Scores)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scores_player_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
