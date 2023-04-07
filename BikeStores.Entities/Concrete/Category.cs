using BikeStores.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStores.Entities.Concrete
{
    [Table("production.categories")]
    public class Category:IEntity
    {
        [Key]
        public int category_id { get; set; }
        public string category_name { get; set; }
    }
}
