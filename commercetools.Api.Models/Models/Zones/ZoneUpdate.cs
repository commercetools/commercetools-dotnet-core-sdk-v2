using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Zones
{
    public class ZoneUpdate 
    {
        public long Version { get; set;}
        
        public List<ZoneUpdateAction> Actions { get; set;}
    }
}
