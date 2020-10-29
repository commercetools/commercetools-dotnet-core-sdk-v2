using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductUpdate))]
    public interface IProductUpdate 
    {
        long Version { get; set;}
        
        List<IProductUpdateAction> Actions { get; set;}
    }
}
