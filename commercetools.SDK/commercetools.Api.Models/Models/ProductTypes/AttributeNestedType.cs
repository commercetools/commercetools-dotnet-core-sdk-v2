using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("nested")]
    public partial class AttributeNestedType : AttributeType
    {
        public ProductTypeReference TypeReference { get; set;}
        public AttributeNestedType()
        { 
           this.Name = "nested";
        }
    }
}
