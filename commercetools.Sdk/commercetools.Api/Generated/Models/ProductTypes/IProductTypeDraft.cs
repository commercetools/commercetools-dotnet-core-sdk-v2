using commercetools.Api.Generated.Models.ProductTypes;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IProductTypeDraft 
    {
        string Key { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<IAttributeDefinitionDraft> Attributes { get; set;}
    }
}
