using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeDraft))]
    public partial interface IProductTypeDraft 
    {
        string Key { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<IAttributeDefinitionDraft> Attributes { get; set;}
    }
}
