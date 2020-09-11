using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class ProductTypeChangeLocalizedEnumValueOrderAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public List<AttributeLocalizedEnumValue> Values { get; set;}
    }
}
