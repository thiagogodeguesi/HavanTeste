using FluentValidation;
using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Domain.Interfaces.Repository;
using HavanTeste.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Services.Services
{
    public class FamiliaProdutoServices : ABaseServices<FamiliaProduto>, IFamiliaProdutoService
    {
        public FamiliaProdutoServices(IFamiliaProdutoRepository repositoryFamiliaProduto) : base(repositoryFamiliaProduto)
        {

        }


    
    }
}
