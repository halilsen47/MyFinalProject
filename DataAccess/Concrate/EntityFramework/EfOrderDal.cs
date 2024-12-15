using Core.DataAccsess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    internal class EfOrderDal: EfEntityRepositoryBase<Order,NorthWindContext>  ,IOrderDal
    {
            
    }
}
