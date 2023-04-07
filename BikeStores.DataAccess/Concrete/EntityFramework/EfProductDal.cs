using BikeStores.DataAccess.Abstract;
using BikeStores.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BikeStores.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, BikeStoresContext>, IProductDal
    {

    }
}
