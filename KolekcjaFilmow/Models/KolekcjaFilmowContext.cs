using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KolekcjaFilmow.Models;

public partial class KolekcjaFilmowContext : DbContext
{
    public KolekcjaFilmowContext()
    {
    }

    public KolekcjaFilmowContext(DbContextOptions<KolekcjaFilmowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Filmy> Filmies { get; set; }

    public virtual DbSet<Kategorie> Kategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=KolekcjaFilmow;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filmy>(entity =>
        {
            entity.HasKey(e => e.IdFilm);

            entity.ToTable("Filmy");

            entity.Property(e => e.Rezyser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tytul)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kategorie>(entity =>
        {
            entity.HasKey(e => e.IdKategoria).HasName("PK_Kategoria");

            entity.ToTable("Kategorie");

            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
