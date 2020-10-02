using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("removeEnumValues")]
    public partial class ProductTypeRemoveEnumValuesAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public List<string> Keys { get; set;}
        public ProductTypeRemoveEnumValuesAction()
        { 
           this.Action = "removeEnumValues";
        }
    }
}
