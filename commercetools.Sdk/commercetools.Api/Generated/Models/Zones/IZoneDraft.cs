using commercetools.Api.Generated.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Zones
{
    public interface IZoneDraft 
    {
        string Key { get; set;}
        
        string Name { get; set;}
        
        string Description { get; set;}
        
        List<ILocation> Locations { get; set;}
    }
}
