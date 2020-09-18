using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("lenum")]
    public class AttributeLocalizedEnumType : AttributeType
    {
        public List<AttributeLocalizedEnumValue> Values { get; set;}
    }
}
