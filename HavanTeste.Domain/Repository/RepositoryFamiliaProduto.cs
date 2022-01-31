using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Domain.Repository
{
    public class RepositoryFamiliaProduto : RepositoryBase<FamiliaProduto>, IFamiliaProdutoRepository
    {
        private readonly HavanContext havanContext;
        private IProdutoService ProdutoService;

        public RepositoryFamiliaProduto(HavanContext havanContext
            ) : base(havanContext)
        {
            this.havanContext = havanContext;
        }

        public IEnumerable<FamiliaProduto> GetAll()
        {
            var familias = havanContext.Set<FamiliaProduto>().ToList();

            foreach (var familia in familias)
            {
                //familia.Produtos = havanContext.Produtos.Where(c => c.IdFamilia == familia.Id).ToList();
                familia.Produtos = havanContext.Set<Produto>().Where(c => c.IdFamilia == familia.Id).ToList();
            }

            return familias;
        }

        public FamiliaProduto GetById(int id)
        {
            var familia = havanContext.Set<FamiliaProduto>().Find(id);
            familia.Produtos = havanContext.Set<Produto>().Where(c => c.IdFamilia == familia.Id);
            return familia;
        }
    }
}
