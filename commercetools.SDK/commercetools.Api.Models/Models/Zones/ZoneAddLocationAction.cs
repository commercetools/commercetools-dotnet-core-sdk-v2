using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("addLocation")]
    public partial class ZoneAddLocationAction : ZoneUpdateAction
    {
        public Location Location { get; set;}
        public ZoneAddLocationAction()
        { 
           this.Action = "addLocation";
        }
    }
}
