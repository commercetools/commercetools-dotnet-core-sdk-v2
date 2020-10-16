using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductTypeUpdateAction> Actions { get; set;}
    }
}
