using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public  partial class ProductTypeUpdate : IProductTypeUpdate
    {
        public long Version { get; set;}
        
        public List<IProductTypeUpdateAction> Actions { get; set;}
    }
}
