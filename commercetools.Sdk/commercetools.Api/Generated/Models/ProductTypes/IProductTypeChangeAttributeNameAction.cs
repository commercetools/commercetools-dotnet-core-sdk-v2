using commercetools.Api.Generated.Models.ProductTypes;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IProductTypeChangeAttributeNameAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        string NewAttributeName { get; set;}
    }
}
