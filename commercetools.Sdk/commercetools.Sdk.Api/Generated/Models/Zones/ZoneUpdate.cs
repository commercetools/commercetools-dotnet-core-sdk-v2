using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneUpdate : IZoneUpdate
    {
        public long Version { get; set;}
        
        public List<IZoneUpdateAction> Actions { get; set;}
    }
}
