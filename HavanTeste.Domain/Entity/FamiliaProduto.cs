using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HavanTeste.Domain.Entity
{
    [Table("familiaproduto", Schema = "public")]
    public class FamiliaProduto
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [NotMapped]
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
