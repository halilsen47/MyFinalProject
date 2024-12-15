using Entities.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint
    //class= referance tip
    //IEntity = IEntity olablir ya da IEntity implament etmiş bir referans tip olabilir
    //new()= new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntitiy,new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T,bool>> filter);

        void Add(T Entity);

        void Update(T Entity);

        void Delete(T Entity);

    }
}
