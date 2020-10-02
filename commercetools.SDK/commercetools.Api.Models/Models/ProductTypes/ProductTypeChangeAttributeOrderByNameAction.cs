using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeOrderByName")]
    public partial class ProductTypeChangeAttributeOrderByNameAction : ProductTypeUpdateAction
    {
        public List<string> AttributeNames { get; set;}
        public ProductTypeChangeAttributeOrderByNameAction()
        { 
           this.Action = "changeAttributeOrderByName";
        }
    }
}
