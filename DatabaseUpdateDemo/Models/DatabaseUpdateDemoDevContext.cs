using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseUpdateDemo.Models;

public partial class DatabaseUpdateDemoDevContext : DbContext
{
    public DatabaseUpdateDemoDevContext()
    {
    }

    public DatabaseUpdateDemoDevContext(DbContextOptions<DatabaseUpdateDemoDevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Currency> Currencies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:sekuredb.database.windows.net,1433;Initial Catalog=DatabaseUpdateDemo-Dev;Persist Security Info=False;User ID=granparamo;Password=Bogota01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__Currency__14470AF03E960332");

            entity.ToTable("Currency");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Abbreviation).HasMaxLength(4);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
