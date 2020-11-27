using Test.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace practice.Repository
{
    public class ProductRepository<TEntity> : IProductRepository<TEntity>
         where TEntity : class
    {
        //private Model1 db;
        private DbContext _dbContext;

        public ProductRepository(DbContext db)
        {
            //db = this.db;
            _dbContext = db;
        }

        public void Add(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            _dbContext.Set<TEntity>().Remove(obj);
            _dbContext.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }


        IEnumerable<TEntity> IProductRepository<TEntity>.Getall()
        {
            return _dbContext.Set<TEntity>();
        }



        TEntity IProductRepository<TEntity>.GetById(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).FirstOrDefault();
        }
    }
}