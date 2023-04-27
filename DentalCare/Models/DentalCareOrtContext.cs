using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DentalCare.Models;

public partial class DentalCareOrtContext : DbContext
{
    public DentalCareOrtContext()
    {
    }

    public DentalCareOrtContext(DbContextOptions<DentalCareOrtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Reserva> Reservas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost; database=DentalCareORT; integrated security=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservas__3214EC07A00D7735");

            entity.Property(e => e.EmailPaciente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especialista)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombrePaciente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoPaciente)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
