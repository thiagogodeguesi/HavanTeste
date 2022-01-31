using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanTeste.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace HavanTeste.Infra.Data.Context
{
    public class HavanContext :DbContext
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

            modelBuilder.Entity<Produto>(new UserMap().Configure);
            modelBuilder.Entity<FamiliaProduto>(new UserMap().Configure);
        }
    }
}

