using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Zones
{
    public class ZoneRemoveLocationAction : ZoneUpdateAction
    {
        public Location Location { get; set;}
    }
}
