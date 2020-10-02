using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductUpdateAction> Actions { get; set;}
    }
}
