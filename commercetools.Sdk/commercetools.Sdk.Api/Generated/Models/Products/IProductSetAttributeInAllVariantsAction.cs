using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetAttributeInAllVariantsAction))]
    public partial interface IProductSetAttributeInAllVariantsAction : IProductUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
        
        bool? Staged { get; set;}
    }
}
