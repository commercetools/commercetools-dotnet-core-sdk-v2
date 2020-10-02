using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("lenum")]
    public partial class AttributeLocalizedEnumType : AttributeType
    {
        public List<AttributeLocalizedEnumValue> Values { get; set;}
        public AttributeLocalizedEnumType()
        { 
           this.Name = "lenum";
        }
    }
}
