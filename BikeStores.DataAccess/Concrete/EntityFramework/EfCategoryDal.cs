using BikeStores.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeStores.Entities.Concrete;

namespace BikeStores.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BikeStoresContext>, ICategoryDal
    {
    }
}
