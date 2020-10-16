using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeOrder")]
    public partial class ProductTypeChangeAttributeOrderAction : ProductTypeUpdateAction
    {
        public List<AttributeDefinition> Attributes { get; set;}
        public ProductTypeChangeAttributeOrderAction()
        { 
           this.Action = "changeAttributeOrder";
        }
    }
}
