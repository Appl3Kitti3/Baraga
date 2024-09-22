using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Baraga.Models.BG;

public partial class BaragaContext : DbContext
{
    public BaragaContext()
    {
    }

    public BaragaContext(DbContextOptions<BaragaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__0CF04B183D17204D");

            entity.ToTable("Member");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
