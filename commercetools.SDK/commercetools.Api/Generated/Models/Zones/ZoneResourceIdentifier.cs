using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("zone")]
    public partial class ZoneResourceIdentifier : ResourceIdentifier
    {
        public ZoneResourceIdentifier()
        { 
           this.TypeId = "zone";
        }
    }
}
