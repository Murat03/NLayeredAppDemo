using BikeStores.Business.Abstract;
using BikeStores.Business.ValidationRules.FluentValidation;
using BikeStores.DataAccess.Abstract;
using BikeStores.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using BikeStores.Business.Utilities;

namespace BikeStores.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public void Add(Product product)
        {
            ProductValidator(product);
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            ProductValidator(product);
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Product cannot deleted!");
            }
        }

        public List<Product> GetAll()
        {
            //Business code
            return _productDal.GetAll(); 
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.category_id == categoryId);
        }

        public List<Product> GetProductByName(string text)
        {
            return _productDal.GetAll(p=>p.product_name.ToLower().Contains(text.ToLower()));
        }
        private static void ProductValidator(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }
        }
    }
}
