global using DiyetDemo.Core;
global using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.DAL.Base.EntityFramework
{
    
    public class EFRepositryBase<TEntity,TContext>:IRepository<TEntity> 
        where TEntity : BaseEntity 
        where TContext: DbContext
    {
        TContext context;

        public EFRepositryBase(TContext context)
        {
            this.context = context;
        }

        public TEntity Add(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            if (context.SaveChanges() > 0)
            { 
                return entity;
            }
            return null;
        }
        public TEntity Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            if (context.SaveChanges() > 0)
            {
                return entity;
            }
            return null;
        }
        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return context.Set<TEntity>().Where(filter).MyInclude(includes).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            if (filter == null)
            {
                return context.Set<TEntity>().MyInclude(includes).ToList();
            }
            else
            {
                return context.Set<TEntity>().Where(filter).MyInclude(includes).ToList();
            }
        }



    }

}
