using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class ProductTypeUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductTypeUpdateAction> Actions { get; set;}
    }
}
