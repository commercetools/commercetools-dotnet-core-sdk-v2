using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [Discriminator(nameof(Action))]
    public abstract class ZoneUpdateAction 
    {
        public string Action { get; set;}
    }
}
