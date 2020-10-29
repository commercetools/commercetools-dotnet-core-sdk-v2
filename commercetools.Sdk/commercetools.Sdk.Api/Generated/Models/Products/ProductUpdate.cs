using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductUpdate : IProductUpdate
    {
        public long Version { get; set;}
        
        public List<IProductUpdateAction> Actions { get; set;}
    }
}
