using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductUpdateAction> Actions { get; set;}
    }
}
