using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changePlainEnumValueLabel")]
    public class ProductTypeChangePlainEnumValueLabelAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributePlainEnumValue NewValue { get; set;}
    }
}
