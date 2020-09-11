using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class AttributeSetType : AttributeType
    {
        public AttributeType ElementType { get; set;}
    }
}
