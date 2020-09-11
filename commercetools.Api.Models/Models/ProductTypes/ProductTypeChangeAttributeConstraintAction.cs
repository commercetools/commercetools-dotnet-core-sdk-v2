using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class ProductTypeChangeAttributeConstraintAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributeConstraintEnumDraft NewValue { get; set;}
    }
}
