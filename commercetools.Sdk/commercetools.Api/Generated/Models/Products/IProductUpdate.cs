using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductUpdate 
    {
        long Version { get; set;}
        
        List<IProductUpdateAction> Actions { get; set;}
    }
}
