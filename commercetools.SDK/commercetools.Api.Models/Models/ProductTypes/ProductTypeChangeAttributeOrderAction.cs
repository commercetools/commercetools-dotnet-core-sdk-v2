using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeOrder")]
    public class ProductTypeChangeAttributeOrderAction : ProductTypeUpdateAction
    {
        public List<AttributeDefinition> Attributes { get; set;}
    }
}
