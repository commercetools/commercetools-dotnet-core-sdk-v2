using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeNestedType : IAttributeNestedType
    {
        public string Name { get; set;}
        
        public IProductTypeReference TypeReference { get; set;}
        public AttributeNestedType()
        { 
           this.Name = "nested";
        }
    }
}
