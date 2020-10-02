using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changePlainEnumValueLabel")]
    public partial class ProductTypeChangePlainEnumValueLabelAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributePlainEnumValue NewValue { get; set;}
        public ProductTypeChangePlainEnumValueLabelAction()
        { 
           this.Action = "changePlainEnumValueLabel";
        }
    }
}
