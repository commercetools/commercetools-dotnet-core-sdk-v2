using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("set")]
    public class AttributeSetType : AttributeType
    {
        public AttributeType ElementType { get; set;}
    }
}
