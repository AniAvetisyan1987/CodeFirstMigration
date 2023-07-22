using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CodeFirstMigration.Entities
{
    public partial class AuthorsContext : DbContext
    {
        public AuthorsContext()
        {
        }

        public AuthorsContext(DbContextOptions<AuthorsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllAuthor> AllAuthors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<CategoryBook> CategoryBooks { get; set; } = null!;
        public virtual DbSet<Categoty> Categoties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Authors;Trusted_Connection=True; TrustServerCertificate=True; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllAuthor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Firstname).HasMaxLength(20);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Lastname).HasMaxLength(20);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CategoryBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CategoryBook");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Categoty>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .HasColumnName("category");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
