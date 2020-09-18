using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [Discriminator(nameof(Action))]
    public abstract class TypeUpdateAction 
    {
        public string Action { get; set;}
    }
}
