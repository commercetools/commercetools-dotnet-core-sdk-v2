using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("changeName")]
    public class ZoneChangeNameAction : ZoneUpdateAction
    {
        public string Name { get; set;}
    }
}
