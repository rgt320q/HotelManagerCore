using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public EfEntityRepositoryBase()
        {
            using (TContext context=new TContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public int Attach(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Attach(entity);
                var result = context.SaveChanges();

                return result;
            }
        }       

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetLastOrDefault(Expression<Func<TEntity, object>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().OrderBy(filter).LastOrDefault();
            }
        }

        public TEntity GetOneInclude(Expression<Func<TEntity, object>> include, Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Include(include).SingleOrDefault(filter);
            }
        }

        public TEntity GetThreeInclude(Expression<Func<TEntity, object>> includeOne, Expression<Func<TEntity, object>> includeTwo, Expression<Func<TEntity, object>> includeThree, Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Include(includeOne).Include(includeTwo).Include(includeThree).SingleOrDefault(filter);
            }
        }

        public TEntity GetTwoInclude(Expression<Func<TEntity, object>> includeOne, Expression<Func<TEntity, object>> includeTwo, Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Include(includeOne).Include(includeTwo).SingleOrDefault(filter);
            }
        }

        public void SaveChanges()
        {
           using(TContext context = new TContext())
            {
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
