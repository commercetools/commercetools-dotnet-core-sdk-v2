using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changePlainEnumValueOrder")]
    public partial class ProductTypeChangePlainEnumValueOrderAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public List<AttributePlainEnumValue> Values { get; set;}
        public ProductTypeChangePlainEnumValueOrderAction()
        { 
           this.Action = "changePlainEnumValueOrder";
        }
    }
}
