using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab2_WebService.Models;

public partial class FallEventsDbContext : DbContext
{
    public FallEventsDbContext()
    {
    }

    public FallEventsDbContext(DbContextOptions<FallEventsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FallEventsG3> FallEventsG3s { get; set; }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
          => optionsBuilder.UseSqlServer("Server=(local);Database=FallEventsDb;User Id=sa;Password=jhostyn;Encrypt=False");
       
    }*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FallEventsG3>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FallEven__3214EC076A45378D");

            entity.ToTable("FallEventsG3");

            entity.Property(e => e.DeviceId).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
