using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeLocalizedEnumType : IAttributeLocalizedEnumType
    {
        public string Name { get; set;}
        
        public List<IAttributeLocalizedEnumValue> Values { get; set;}
        public AttributeLocalizedEnumType()
        { 
           this.Name = "lenum";
        }
    }
}
