using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("removeLocation")]
    public class ZoneRemoveLocationAction : ZoneUpdateAction
    {
        public Location Location { get; set;}
    }
}
