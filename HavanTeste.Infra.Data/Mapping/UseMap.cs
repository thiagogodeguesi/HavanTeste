using HavanTeste.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Infra.Data.Mapping
{
    public class UseMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("varchar(120)");

            builder.Property(prop => prop.SKU)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("sku")
               .HasColumnType("varchar(120)");

            builder.Property(prop => prop.UrlImagem)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("urlimagem")
                .HasColumnType("varchar(120)");

            builder.Property(prop => prop.Preco)
                .HasConversion(prop => prop, prop => prop)
                .HasColumnName("preco")
                .HasColumnType("money");

            builder.Property(prop => prop.IdFamilia)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnName("idfamilia")
                .HasColumnType("int");
        }

    }
}
