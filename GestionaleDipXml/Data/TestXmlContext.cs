using System;
using System.Collections.Generic;
using GestionaleDipXml.Model;
using Microsoft.EntityFrameworkCore;

namespace GestionaleDipXml.Data;

public partial class TestXmlContext : DbContext
{
    public TestXmlContext()
    {
    }

    public TestXmlContext(DbContextOptions<TestXmlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SevenDataProdotto> SevenDataProdottos { get; set; }

    public virtual DbSet<SevenDataRapportoInformativo> SevenDataRapportoInformativos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestXml;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<SevenDataProdotto>(entity =>
        {
            entity.HasKey(e => e.Oid);

            entity.ToTable("SevenDataProdotto");

            entity.Property(e => e.Oid)
                .ValueGeneratedNever()
                .HasColumnName("OID");
            entity.Property(e => e.Nome).HasMaxLength(50);
        });

        modelBuilder.Entity<SevenDataRapportoInformativo>(entity =>
        {
            entity.HasKey(e => e.Oid);

            entity.ToTable("SevenDataRapportoInformativo");

            entity.Property(e => e.Oid).HasColumnName("OID");
            entity.Property(e => e.DataRispostaShort).HasComputedColumnSql("(CONVERT([date],[DataRisposta]))", true);
            entity.Property(e => e.IdrichiestaJson).HasColumnName("IDRichiestaJson");
            entity.Property(e => e.IdrichiestaPdf).HasColumnName("IDRichiestaPDF");
            entity.Property(e => e.Negativita).HasMaxLength(10);
            entity.Property(e => e.OidCliente).HasColumnName("OID_Cliente");
            entity.Property(e => e.OidProdotto).HasColumnName("OID_Prodotto");
            entity.Property(e => e.StatoAttivita).HasMaxLength(50);
            entity.Property(e => e.Xml)
                .HasColumnType("xml")
                .HasColumnName("XML");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
