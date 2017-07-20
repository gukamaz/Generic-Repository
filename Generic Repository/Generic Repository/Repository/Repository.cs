using Generic_Repository.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Generic_Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(t => !t.IsDeleted).FirstOrDefault(predicate);
        }

        public TEntity Get(int ID)
        {
            return Context.Set<TEntity>().Find(ID);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().Where(t => !t.IsDeleted);
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        public IQueryable<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(t => !t.IsDeleted).Where(predicate);
        }

        public void Remove(int entityID)
        {
            var entity = Get(entityID);
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;
        }

        public void Remove(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;
        }

        Expression IQueryable.Expression
        {
            get
            {
                return GetAll().Expression;
            }
        }

        Type IQueryable.ElementType
        {
            get
            {
                return typeof (TEntity);
            }
        }

        IQueryProvider IQueryable.Provider
        {
            get
            {
                return GetAll().Provider;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetAll().GetEnumerator();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
