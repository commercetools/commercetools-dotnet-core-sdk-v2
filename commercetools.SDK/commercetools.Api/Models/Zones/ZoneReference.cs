using commercetools.Api.Models.Common;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("zone")]
    public partial class ZoneReference : Reference
    {
        public Zone Obj { get; set;}
        public ZoneReference()
        { 
           this.TypeId = "zone";
        }
    }
}
