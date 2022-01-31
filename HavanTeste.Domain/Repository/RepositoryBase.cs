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
    public class RepositoryBase<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
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
