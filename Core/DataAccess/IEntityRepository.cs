using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T GetLastOrDefault(Expression<Func<T, object>> filter);
        T GetOneInclude(
            Expression<Func<T, object>> include,
            Expression<Func<T, bool>> filter);
        T GetTwoInclude(
            Expression<Func<T, object>> includeOne, 
            Expression<Func<T, object>> includeTwo, 
            Expression<Func<T, bool>> filter);
        T GetThreeInclude(
            Expression<Func<T, object>> includeOne, 
            Expression<Func<T, object>> includeTwo, 
            Expression<Func<T, object>> includeThree, 
            Expression<Func<T, bool>> filter);
        void Add(T entity);       
        int Attach(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
