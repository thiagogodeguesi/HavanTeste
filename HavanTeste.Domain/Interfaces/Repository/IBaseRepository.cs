using HavanTeste.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity>
    {
        void Add(TEntity obj);

        void Remove(TEntity obj);

        void Update(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
