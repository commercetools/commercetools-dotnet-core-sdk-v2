using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeLocalizedEnumValueLabel")]
    public partial class ProductTypeChangeLocalizedEnumValueLabelAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributeLocalizedEnumValue NewValue { get; set;}
        public ProductTypeChangeLocalizedEnumValueLabelAction()
        { 
           this.Action = "changeLocalizedEnumValueLabel";
        }
    }
}
