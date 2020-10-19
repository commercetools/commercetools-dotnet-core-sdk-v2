using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneUpdate 
    {
        public long Version { get; set;}
        
        public List<ZoneUpdateAction> Actions { get; set;}
    }
}
