using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class ProductUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductUpdateAction> Actions { get; set;}
    }
}
