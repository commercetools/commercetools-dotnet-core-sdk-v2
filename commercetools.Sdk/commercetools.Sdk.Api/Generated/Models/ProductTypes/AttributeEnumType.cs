using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeEnumType : IAttributeEnumType
    {
        public string Name { get; set;}
        
        public List<IAttributePlainEnumValue> Values { get; set;}
        public AttributeEnumType()
        { 
           this.Name = "enum";
        }
    }
}
