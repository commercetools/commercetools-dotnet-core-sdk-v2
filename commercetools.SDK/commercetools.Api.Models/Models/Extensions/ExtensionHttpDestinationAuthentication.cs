using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [Discriminator(nameof(Type))]
    public abstract class ExtensionHttpDestinationAuthentication 
    {
        public string Type { get; set;}
    }
}
