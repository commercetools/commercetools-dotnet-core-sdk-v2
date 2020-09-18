using commercetools.Api.Models.Common;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("zone")]
    public class ZoneReference : Reference
    {
        public Zone Obj { get; set;}
    }
}
