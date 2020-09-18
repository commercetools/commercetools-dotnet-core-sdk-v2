using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("setDescription")]
    public class ZoneSetDescriptionAction : ZoneUpdateAction
    {
        public string Description { get; set;}
    }
}
