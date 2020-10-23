using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetAttributeInAllVariantsAction : IProductUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
        
        bool Staged { get; set;}
    }
}
