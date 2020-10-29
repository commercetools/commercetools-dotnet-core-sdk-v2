using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeAddAttributeDefinitionAction : IProductTypeAddAttributeDefinitionAction
    {
        public string Action { get; set;}
        
        public IAttributeDefinitionDraft Attribute { get; set;}
        public ProductTypeAddAttributeDefinitionAction()
        { 
           this.Action = "addAttributeDefinition";
        }
    }
}
