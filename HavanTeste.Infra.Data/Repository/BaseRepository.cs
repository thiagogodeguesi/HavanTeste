using HavanTeste.Domain.Interfaces;
using HavanTeste.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanTeste.Infra.Data.Repository
{
    class BaseRepository<TEntity> : IBase<TEntity> where TEntity : class
    {
        protected readonly HavanContext _HavanContext;

        public BaseRepository(HavanContext havanContext)
        {
            _HavanContext = havanContext;
        }


        private readonly HavanContext havanContext;

        public RepositoryBase(HavanContext havanContext)
        {
            this.havanContext = havanContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                havanContext.Set<TEntity>().Add(obj);
                havanContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return havanContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return havanContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                havanContext.Set<TEntity>().Remove(obj);
                havanContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                havanContext.Entry(obj).State = EntityState.Modified;
                havanContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
