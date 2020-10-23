using commercetools.Api.Generated.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Zones
{
    public interface IZoneUpdate 
    {
        long Version { get; set;}
        
        List<IZoneUpdateAction> Actions { get; set;}
    }
}
