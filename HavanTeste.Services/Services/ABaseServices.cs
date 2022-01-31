using FluentValidation;
using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanTeste.Domain.Interfaces.Repository;

namespace HavanTeste.Services.Services
{
    public abstract class ABaseServices<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repositoryBase;

        public ABaseServices(IBaseRepository<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }


        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }


        public IEnumerable<TEntity> GetAll() => _repositoryBase.GetAll();


        public TEntity GetById(int id) => _repositoryBase.GetById(id);

        public void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }


        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }



        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
