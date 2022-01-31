using HavanTeste.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Domain.Repository
{
    public class HavanContext : DbContext
    {
        public HavanContext(DbContextOptions<HavanContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<FamiliaProduto> FamiliaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FamiliaProduto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nome).HasColumnName("nome");
            });
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdFamilia).HasColumnName("idfamilia");
                entity.Property(e => e.Nome).HasColumnName("nome");
                entity.Property(e => e.UrlImagem).HasColumnName("urlimagem");
                entity.Property(e => e.SKU).HasColumnName("sku");
                entity.Property(e => e.Preco).HasColumnName("preco").HasColumnType("money");

            });
        }
        
    }
}
