using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [Discriminator(nameof(Action))]
    public abstract partial class ZoneUpdateAction 
    {
        public string Action { get; set;}
    }
}
