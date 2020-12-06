using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PoliHack.Data
{
    public partial class PoliHackContext : DbContext
    {
        public PoliHackContext()
        {
        }

        /*public PoliHackContext(DbContextOptions<PoliHackContext> options)
            : base(options)
        {
        }*/

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<ContactMessage> ContactMessages { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<ToDoIdea> ToDoIdeas { get; set; }
        public virtual DbSet<Tvseries> Tvseries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=GRIZZLLY-PC;Initial Catalog=PoliHack;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Descriere)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Imagine)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titlu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ContactMessage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mesaj)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("mesaj");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.Album)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Artist)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imagine)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkApplemusic)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkSpotify)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkTidal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkYoutube)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titlu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ToDoIdea>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mesaj)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("mesaj");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Tvseries>(entity =>
            {
                entity.ToTable("TVSeries");

                entity.Property(e => e.Descriere)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Imagine)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkAmazon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkImdb)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LinkIMDB");

                entity.Property(e => e.LinkNetflix)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkRt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LinkRT");

                entity.Property(e => e.Titlu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
