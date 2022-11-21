using System;
using System.Collections.Generic;
using Capitulo04.HelloEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Capitulo04.HelloEntityFramework.Data;

/// <summary>
/// Generate command:
/// scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Data Source=LOCALHOST; Initial Catalog=NorthWind; trusted_connection=yes; Encrypt=false" -outputdir "Models" -ContextDir "Data" -DataAnnotations -table "Customers"
/// </summary>
public partial class NorthWindContext : DbContext
{
    public NorthWindContext()
    {
    }

    public NorthWindContext(DbContextOptions<NorthWindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LOCALHOST; Initial Catalog=NorthWind; trusted_connection=yes; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
