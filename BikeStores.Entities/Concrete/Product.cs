﻿using BikeStores.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStores.Entities.Concrete
{
    [Table("production.products")]
    public class Product:IEntity
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int brand_id { get; set; }
        public int category_id { get; set; }
        public Int16 model_year { get; set; }
        public decimal list_price { get; set; }
    }
}
