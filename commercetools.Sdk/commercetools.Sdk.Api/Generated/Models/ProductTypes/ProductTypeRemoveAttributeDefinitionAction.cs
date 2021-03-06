using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeRemoveAttributeDefinitionAction : IProductTypeRemoveAttributeDefinitionAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        public ProductTypeRemoveAttributeDefinitionAction()
        { 
           this.Action = "removeAttributeDefinition";
        }
    }
}
