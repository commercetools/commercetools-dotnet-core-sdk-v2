using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeName")]
    public partial class ProductTypeChangeAttributeNameAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string NewAttributeName { get; set;}
        public ProductTypeChangeAttributeNameAction()
        { 
           this.Action = "changeAttributeName";
        }
    }
}
