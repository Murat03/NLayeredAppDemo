using BikeStores.Business.Abstract;
using BikeStores.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStores.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.product_name).NotEmpty().WithMessage("Product name cannot be empty!");
            RuleFor(p => p.category_id).NotEmpty();
            RuleFor(p => p.list_price).NotEmpty();
            RuleFor(p => p.brand_id).NotEmpty();
            RuleFor(p => p.model_year).NotEmpty();

            RuleFor(p => p.list_price).GreaterThan(0);
            RuleFor(p => p.model_year).GreaterThanOrEqualTo((short)1800);
            RuleFor(p => p.list_price).GreaterThan(10).When(p => p.category_id == 2);

            RuleFor(p => p.product_name).Must(StartWithA).WithMessage("Product name must start with 'A'");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
