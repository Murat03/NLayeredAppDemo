﻿using BikeStores.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStores.Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
    }
}