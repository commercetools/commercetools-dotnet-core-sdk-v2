using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Zones
{
    public class ZoneDraft 
    {
        public string Key { get; set;}
        
        public string Name { get; set;}
        
        public string Description { get; set;}
        
        public List<Location> Locations { get; set;}
    }
}
