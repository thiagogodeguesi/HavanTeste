using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Repository;
using HavanTeste.Domain.Interfaces.Repository;

namespace HavanTeste.Services.Services
{
    public class ProdutoServices : ABaseServices<Produto>, IProdutoService
    {
        public ProdutoServices(IProdutoRepository repositoryProduto) : base(repositoryProduto)
        {

        }



    }

}
