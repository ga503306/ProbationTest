using Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practice.Repository
{
    public interface IProductRepository<TEntity>
    {
        IEnumerable<TEntity> Getall();
        TEntity GetById(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Save();
    }
}
