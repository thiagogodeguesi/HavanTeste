using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HavanTeste.Domain.Entity
{
    [Table("produto", Schema = "public")]
    public class Produto
    {
        public Produto()
        { }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("preco")]
        public double Preco { get; set; }

        [Column("sku")]
        public string SKU { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("urlimagem")]
        public string UrlImagem { get; set; }

        [ForeignKey("familiaproduto")]
        [Column(Order = 1)]
        public int IdFamilia { get; set; }

    }
}
