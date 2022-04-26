﻿using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductBrandAgg
{
    public class ProductBrand
    {
        #region Propertied
        public int Id { get; private set; }
        public string Title { get; private set; }
        #endregion

        #region Relations
        public List<Product> Products{ get; set; }
        #endregion


        public ProductBrand(string title)
        {
            Title = title;
            Products=new List<Product>();
        }
        public void Edit(string title)
        {
            Title=title;
        }
    }
}
