﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }
    }
}
