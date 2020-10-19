using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("addAttributeDefinition")]
    public partial class ProductTypeAddAttributeDefinitionAction : ProductTypeUpdateAction
    {
        public AttributeDefinitionDraft Attribute { get; set;}
        public ProductTypeAddAttributeDefinitionAction()
        { 
           this.Action = "addAttributeDefinition";
        }
    }
}
