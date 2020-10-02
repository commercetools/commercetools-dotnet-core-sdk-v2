using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeLocalizedEnumValueOrder")]
    public partial class ProductTypeChangeLocalizedEnumValueOrderAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public List<AttributeLocalizedEnumValue> Values { get; set;}
        public ProductTypeChangeLocalizedEnumValueOrderAction()
        { 
           this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
