using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("addAttributeDefinition")]
    public class ProductTypeAddAttributeDefinitionAction : ProductTypeUpdateAction
    {
        public AttributeDefinitionDraft Attribute { get; set;}
    }
}
