using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [Discriminator(nameof(Name))]
    public abstract class AttributeType 
    {
        public string Name { get; set;}
    }
}
