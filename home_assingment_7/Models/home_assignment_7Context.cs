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

        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Score> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=PostgreSQL 13;Host=localhost;Port=5432;Username=postgres;Password=root;Database=home_assignment_7");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Finland.1252");

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("levels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("players");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Score>(entity =>
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
