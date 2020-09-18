using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [Discriminator(nameof(Name))]
    public abstract class FieldType 
    {
        public string Name { get; set;}
    }
}
