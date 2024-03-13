using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models;

public partial class BookStoreContext : DbContext
{
    public BookStoreContext()
    {
    }

    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__490D1AE1CE4C04F4");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("book_id");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("author_name");
            entity.Property(e => e.BookName)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("book_name");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("cost");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
