using System;
using System.Collections.Generic;
using GUI.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace GUI.Repository;

public partial class MoDbContext : DbContext
{
    public MoDbContext()
    {
    }

    public MoDbContext(DbContextOptions<MoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Borrow> Borrows { get; set; }

    public virtual DbSet<Borrower> Borrowers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=THANHPHONG;Initial Catalog=LibraryManagementSystem;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.BookId).IsFixedLength();
            entity.Property(e => e.Author).IsFixedLength();
            entity.Property(e => e.Bookname).IsFixedLength();
        });

        modelBuilder.Entity<Borrow>(entity =>
        {
            entity.Property(e => e.BorrowerId).IsFixedLength();
            entity.Property(e => e.BookId).IsFixedLength();

            entity.HasOne(d => d.Book).WithMany(p => p.Borrows)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BORROW_BOOK");

            entity.HasOne(d => d.Borrower).WithMany(p => p.Borrows)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BORROW_BORROWER");
        });

        modelBuilder.Entity<Borrower>(entity =>
        {
            entity.Property(e => e.BorrowerId).IsFixedLength();
            entity.Property(e => e.Address).IsFixedLength();
            entity.Property(e => e.Firstname).IsFixedLength();
            entity.Property(e => e.Lastname).IsFixedLength();
            entity.Property(e => e.Phone).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
