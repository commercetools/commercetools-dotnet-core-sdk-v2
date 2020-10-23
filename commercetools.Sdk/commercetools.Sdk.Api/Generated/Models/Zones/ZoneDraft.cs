using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public  partial class ZoneDraft : IZoneDraft
    {
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<ILocation> Locations { get; set;}
    }
}
