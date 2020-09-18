using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DiscriminatorValue("setKey")]
    public class ZoneSetKeyAction : ZoneUpdateAction
    {
        public string Key { get; set;}
    }
}
