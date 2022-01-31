using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Domain.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IProdutoRepository
            
    {
        private readonly HavanContext havanContext;

        public RepositoryProduto(HavanContext havanContext) : base(havanContext)
        {
            this.havanContext = havanContext;
        }

        

    }
}
