using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityDataBaseFirst2.Models;

public partial class HastaneDbContext : DbContext
{
    public HastaneDbContext()
    {
    }

    public HastaneDbContext(DbContextOptions<HastaneDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doktorlar> Doktorlars { get; set; }

    public virtual DbSet<Hastalar> Hastalars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MERT\\SQLEXPRESS;Database=HastaneDB;User ID=OzgurZaman;Password=2119;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doktorlar>(entity =>
        {
            entity.HasKey(e => e.DoktorId);

            entity.ToTable("Doktorlar");

            entity.Property(e => e.DoktorId).HasColumnName("DoktorID");
        });

        modelBuilder.Entity<Hastalar>(entity =>
        {
            entity.HasKey(e => e.HastaId);

            entity.ToTable("Hastalar");

            entity.Property(e => e.HastaId).HasColumnName("HastaID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
