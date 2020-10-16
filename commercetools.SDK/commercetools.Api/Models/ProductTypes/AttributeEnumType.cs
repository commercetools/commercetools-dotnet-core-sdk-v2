using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("enum")]
    public partial class AttributeEnumType : AttributeType
    {
        public List<AttributePlainEnumValue> Values { get; set;}
        public AttributeEnumType()
        { 
           this.Name = "enum";
        }
    }
}
