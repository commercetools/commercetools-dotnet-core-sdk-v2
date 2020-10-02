using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("addLocalizedEnumValue")]
    public partial class ProductTypeAddLocalizedEnumValueAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributeLocalizedEnumValue Value { get; set;}
        public ProductTypeAddLocalizedEnumValueAction()
        { 
           this.Action = "addLocalizedEnumValue";
        }
    }
}
