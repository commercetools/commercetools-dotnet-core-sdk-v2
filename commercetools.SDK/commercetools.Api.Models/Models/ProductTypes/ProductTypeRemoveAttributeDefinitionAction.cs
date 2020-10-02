using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("removeAttributeDefinition")]
    public partial class ProductTypeRemoveAttributeDefinitionAction : ProductTypeUpdateAction
    {
        public string Name { get; set;}
        public ProductTypeRemoveAttributeDefinitionAction()
        { 
           this.Action = "removeAttributeDefinition";
        }
    }
}
