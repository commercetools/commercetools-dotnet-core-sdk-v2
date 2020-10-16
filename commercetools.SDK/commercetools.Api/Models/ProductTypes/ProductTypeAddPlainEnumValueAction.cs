using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("addPlainEnumValue")]
    public partial class ProductTypeAddPlainEnumValueAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public AttributePlainEnumValue Value { get; set;}
        public ProductTypeAddPlainEnumValueAction()
        { 
           this.Action = "addPlainEnumValue";
        }
    }
}
