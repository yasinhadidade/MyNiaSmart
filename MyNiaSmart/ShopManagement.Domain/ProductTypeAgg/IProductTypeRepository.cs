﻿using _0_Framework.Domain;
using ShopManagement.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductTypeAgg
{
    public interface IProductTypeRepository:IRepository<int,ProductType>
    {
        EditProductType GetDetails(int id);
        List<ProductTypeViewModel> GetList();
    }
}
