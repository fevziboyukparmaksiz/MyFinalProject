using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic Constraint
    // Class : Referans tip 
    // IEntity olabilir ya da onu implemente eden bir nesne olabilir
    // new(): newlenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);  // =null filtre vermeyedebilirsin demek !!!    
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
