using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [Discriminator(nameof(Type))]
    public abstract class Destination 
    {
        public string Type { get; set;}
    }
}
