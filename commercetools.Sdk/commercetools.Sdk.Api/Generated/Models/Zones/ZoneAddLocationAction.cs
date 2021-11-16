using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneAddLocationAction : IZoneAddLocationAction
    {
        public string Action { get; set;}
        
        public ILocation Location { get; set;}
        public ZoneAddLocationAction()
        { 
           this.Action = "addLocation";
        }
    }
}
