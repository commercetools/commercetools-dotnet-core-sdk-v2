using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeOrderByName")]
    public class ProductTypeChangeAttributeOrderByNameAction : ProductTypeUpdateAction
    {
        public List<string> AttributeNames { get; set;}
    }
}
